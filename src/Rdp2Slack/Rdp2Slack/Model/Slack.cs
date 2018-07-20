using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rdp2Slack.Database;

namespace Rdp2Slack.Model
{
    public class Slack : System.Attribute
    {
        private int IdSlack { get; set; }
        private string SlackName { get; set; }
        private int IdUser { get; set; }

        public Slack(string slackName, int idUser)
        {
            SlackName = slackName;
            IdUser = idUser;
        }

        public static Slack Get(int id)
        {
            return DatabaseHelper.GetById<Slack>(id);
        }

        public static List<Slack> GetAll()
        {
            return DatabaseHelper.ReadAll<Slack>();
        }
    }
}
