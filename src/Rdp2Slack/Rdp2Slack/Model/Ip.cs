using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Rdp2Slack.Database;

namespace Rdp2Slack.Model
{
    public class Ip : System.Attribute
    {
        private int Id { get; set; }
        private string Address { get; set; }
        private int IdUser { get; set; }

        public Ip(string address, int idUser)
        {
            if (string.IsNullOrWhiteSpace(address))
                throw new Exception("Endereço IP nulo");

            IPAddress outAddress;
            if (!IPAddress.TryParse(address, out outAddress))
                throw new Exception("Endereço IP inválido");

            this.Address = address;
            this.IdUser = idUser;
        }

        public static Ip Get(int id)
        {
            return DatabaseHelper.GetById<Ip>(id);
        }

        public static List<Ip> GetAll()
        {
            return DatabaseHelper.ReadAll<Ip>();
        }
    }
}
