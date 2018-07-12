using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rdp2Slack.Database;

namespace Rdp2Slack.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public static User GetUser(int id) {
            return DatabaseHelper.GetById<User>(id);
        }

        //private Slack GetSlack()
        //{
        //    CreateAndOpenDb
        //}

        //private void SetSlack(Slack value)
        //{
        //    slack = value;
        //}

        //public Ip GetIpAddress()
        //{
        //    return ipAddress;
        //}

        //public void SetIpAddress(Ip value)
        //{
        //    ipAddress = value;
        //}

        //public static List<User> GetAllRecords()
        //{
        //    DatabaseHelper.CreateAndOpenDb();
        //    ExecuteNonQuery
        //    //using (var db = .))
        //    //{
        //    //    return db.Query<Author>
        //    //    (“Select * From Author”).ToList();
        //    //}
        //}
    }
}
