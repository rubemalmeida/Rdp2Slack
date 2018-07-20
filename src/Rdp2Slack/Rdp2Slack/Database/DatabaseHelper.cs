using Dapper;
using Rdp2Slack.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rdp2Slack.Database
{
    public static class DatabaseHelper
    {
        private static SQLiteConnection _dbConnection;

        private static void SeedDatabase()
        {
            //// Create a Users table
            //_dbConnection.ExecuteNonQuery(@"
            //CREATE TABLE IF NOT EXISTS [User] (
            //    [IdUser] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
            //    [Nome] NVARCHAR(64) NOT NULL,
            //    [Ip] NVARCHAR(15) NOT NULL,
            //    [Slack] NVARCHAR(64) NOT NULL,
            //    [DateCreated] TIMESTAMP DEFAULT CURRENT_TIMESTAMP
            //)");
            //
            //// Create a Access table
            //_dbConnection.ExecuteNonQuery(@"
            //CREATE TABLE IF NOT EXISTS [Access] (
            //    [IdAccess] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
            //    [IdUser] INT NOT NULL,
            //    [IdUserKicked] INT NULL,
            //    [DateCreated] TIMESTAMP DEFAULT CURRENT_TIMESTAMP
            //)");
        }

        public static SQLiteConnection CreateAndOpenDb()
        {
            var existFile = true;
            var dbFilePath = "./base.sqlite";
            if (!File.Exists(dbFilePath))
            {
                existFile = false;
                SQLiteConnection.CreateFile(dbFilePath);
            }
            if (_dbConnection == null)
                _dbConnection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;");

            if (_dbConnection.State != ConnectionState.Open)
                _dbConnection.Open();

            if (!existFile)
                SeedDatabase();

            return _dbConnection;
        }
        
        public static List<T> ReadAll<T>(string whereCondition = null, bool showDeleted = false)
        {
            string query = $"SELECT * FROM { typeof(T).Name } WHERE Deleted={(showDeleted ? "1" : "0")} {(!string.IsNullOrEmpty(whereCondition) ? whereCondition : "")}";
            return CreateAndOpenDb().Query<T>(query).ToList();
        }

        public static T GetById<T>(this int id)
        {
            return CreateAndOpenDb().Query<T>($"SELECT * FROM { typeof(T).Name } WHERE Id = {id} AND Deleted=0;").SingleOrDefault();
        }

        public static int Insert<T>(string column, string values)
        {
            return CreateAndOpenDb().Execute($"INSERT INTO { typeof(T).Name } ({column}) VALUES ({values});");
        }

        public static int Update<T>(string columnAndValue, string condition)
        {
            return CreateAndOpenDb().Execute($"UPDATE { typeof(T).Name } SET ({columnAndValue}) WHERE ({condition});");
        }

        public static void Delete<T>(int id)
        {
            //CreateAndOpenDb().Execute($"DELETE FROM { typeof(T).Name } WHERE Id={id};");
            string query = $"UPDATE { typeof(T).Name } SET (Deleted=1, DateUpdate='{DateTime.Now.ToShortDateString()}') WHERE (Id={id});";
            CreateAndOpenDb().Execute(query);
        }

        //public static T SaveOrUpdate<T>(this object instance)
        //{
        //    string query = string.Empty;
        //    System.Attribute[] attrs = System.Attribute.GetCustomAttributes(typeof(T));
        //    
        //    foreach (System.Attribute attr in attrs)
        //    {
        //        if(attr is Access)
        //        {
        //
        //        }
        //        else if (attr is Ip)
        //        {
        //
        //        }
        //        else if (attr is Slack)
        //        {
        //
        //        }
        //        else if (attr is User)
        //        {
        //
        //        }
        //
        //        //if (attr is Author)
        //        //{
        //        //    Author a = (Author)attr;
        //        //    System.Console.WriteLine("   {0}, version {1:f}", a.GetName(), a.version);
        //        //}
        //    }
        //
        //
        //    //if (instance.Id == 0)
        //    //{
        //    //    query = $@"INSER INTO ";
        //    //}
        //
        //    //return CreateAndOpenDb().Query<T>($"SELECT * FROM { typeof(T).Name } WHERE Id = { id }").SingleOrDefault();
        //}

        public static void ExecuteNonQuery(this SQLiteConnection connection, string commandText)
        {
            // Ensure we have a connection
            if (connection == null)
            {
                throw new NullReferenceException("Please provide a connection");
            }

            // Ensure that the connection state is Open
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            // Use Dapper to execute the given query
            connection.Execute(commandText);
        }
    }
}
