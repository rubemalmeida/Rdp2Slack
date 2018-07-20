using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rdp2Slack.Database;

namespace Rdp2Slack.Model
{
    public class Access : System.Attribute
    {
        public int Id { get; set; }
        public int IdSlack { get; set; }
        public string Address { get; set; }
        public int IdSlackKicked { get; set; }
        public string AddressKicked { get; set; }
        public DateTime Date { get; set; }

        public Access(int? idSlack = null, string address = null, int? idSlackKicked = null, string addressKicked = null)
        {
            if (!idSlack.HasValue && string.IsNullOrEmpty(address))
                throw new Exception("");

            this.Date = DateTime.Now;
        }
        
        public static Access Get(int id)
        {
            return DatabaseHelper.GetById<Access>(id);
        }

        public static List<Access> GetAll()
        {
            return DatabaseHelper.ReadAll<Access>();
        }
    }
}
