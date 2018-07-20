using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rdp2Slack.Database;

namespace Rdp2Slack.Model
{
    public class User : System.Attribute
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Slack { get; set; }
        public string IP { get; set; }

        public User(string nome, string slack, string ip)
        {
            Nome = nome;
            Slack = slack;
            IP = ip;
        }

        //public static User Get(int id)
        //{
        //    return DatabaseHelper.GetById<User>(id);
        //}

        //public static List<User> GetAll()
        //{
        //    return DatabaseHelper.ReadAll<User>();
        //}

        //public int Insert()
        //{
        //    this.Id = DatabaseHelper.Insert<User>("Nome", this.Nome);
        //    return this.Id;
        //}

        //public int Update()
        //{
        //    this.Id = DatabaseHelper.Update<User>($"Nome='{this.Nome}'", $"Id={this.Id}");
        //    return this.Id;
        //}

        //public void Delete()
        //{
        //    DatabaseHelper.Delete<User>(this.Id);
        //}

    }
}
