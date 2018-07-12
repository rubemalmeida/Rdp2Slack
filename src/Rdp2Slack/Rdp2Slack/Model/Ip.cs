using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Rdp2Slack.Model
{
    public class Ip
    {
        private int IdIp { get; set; }
        private string Address { get; set; }
        private int IdUser { get; set; }

        public Ip(string ip)
        {
            if (string.IsNullOrWhiteSpace(ip))
                throw new Exception("Endereço IP nulo");

            IPAddress address;
            if (!IPAddress.TryParse(ip, out address))
                throw new Exception("Endereço IP inválido");

            this.Address = ip;
        }
    }
}
