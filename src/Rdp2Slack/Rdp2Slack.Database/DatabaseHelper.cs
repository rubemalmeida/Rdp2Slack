using Dapper;
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
        
        static void CreateAndOpenDb()
        {
            var dbFilePath = "./TestDb.sqlite";
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }
            _dbConnection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;");
            _dbConnection.Open();
        }
        
        static void ExecuteNonQuery(this SQLiteConnection connection, string commandText)
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

        static void SeedDatabase()
        {
            // Create a Users table
            _dbConnection.ExecuteNonQuery(@"
            CREATE TABLE IF NOT EXISTS [User] (
                [IdUser] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                [Nome] NVARCHAR(64) NOT NULL,
                [Ip] NVARCHAR(15) NOT NULL,
                [Slack] NVARCHAR(64) NOT NULL,
                [DateCreated] TIMESTAMP DEFAULT CURRENT_TIMESTAMP
            )");

            // Create a Access table
            _dbConnection.ExecuteNonQuery(@"
            CREATE TABLE IF NOT EXISTS [Access] (
                [IdAccess] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                [IdUser] INT NOT NULL,
                [IdUserKicked] INT NULL,
                [DateCreated] TIMESTAMP DEFAULT CURRENT_TIMESTAMP
            )");
        }

    }
}
