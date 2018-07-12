using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rdp2Slack.Database;

namespace Rdp2Slack.Model
{
    public class Access
    {
        public int Id { get; set; }
        public int IdSlack { get; set; }
        public int IdSlackKicked { get; set; }
        public string IpKicked { get; set; }
        public DateTime Date { get; set; }
        
        public static Access GetUser(int id)
        {
            return DatabaseHelper.GetById<Access>(id);
        }

        public static List<Access> GetAll()
        {
            return DatabaseHelper.ReadAll<Access>();
        }
    }
}
