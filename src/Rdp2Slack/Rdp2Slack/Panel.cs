using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;
using System.Configuration;
using Rdp2Slack.Database;
using Rdp2Slack.Model;
using System.IO;
using System.Net;
using RestSharp;

namespace Rdp2Slack
{
    public partial class Panel : MetroForm
    {
        private bool UsandoRemoto { get; set; }
        private string IpUsando { get; set; }
        private Timer monitor { get; set; }

        public Panel()
        {
            InitializeComponent();
            Monitorar();
        }

        private void ObterDados()
        {
            //Nome = txtNome.Text;
            //IP = txtIP.Text;
            //Slack = txtSlack.Text;

            //string text = System.IO.File.ReadAllText(dataFile);
            //string[] splittedText = text.Split(' ');

            var rows = new List<string[]>();
            foreach (var line in System.IO.File.ReadLines(""))
            {
                var arr = line.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                rows.Add(arr);
            }
            //return rows.ToArray();

        }

        private bool Valida()
        {
            string erros = null;
            bool valido = false;

            try
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtIP.Text) || string.IsNullOrWhiteSpace(txtSlack.Text))
                    erros += $"{Environment.NewLine}- Campo vazio não dá, brow!";

                if (!(txtNome.Text.Length > 3))
                    erros += $"{Environment.NewLine}- Nome pra que, né?";

                IPAddress ip = null;
                if (!IPAddress.TryParse(txtIP.Text, out ip))
                    erros += $"{Environment.NewLine}- E esse IP aí?";

                if (!(txtSlack.Text.Length > 3))
                    erros += $"{Environment.NewLine}- Cade o Slack?";
            }
            catch
            {
                erros += $"{Environment.NewLine}- Erro sinistro 😕";
            }
            finally
            {
                if (!string.IsNullOrWhiteSpace(erros))
                {
                    valido = false;
                    MessageBox.Show(this, $"Tem uns erros aí..\n{erros}", "Erroooou", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //var messageBox = new MetroMessageBox();
                    //messageBox.Text = "";
                    //messageBox.Show(this);
                }
                else
                    valido = true;
            }

            return valido;
        }

        private void LimpaCampos()
        {
            txtNome.Text = "";
            txtIP.Text = "";
            txtSlack.Text = "";
        }

        private void Monitorar()
        {
            int segundos = Convert.ToInt16(ConfigurationSettings.AppSettings["MonitorarSegundos"]);
            monitor = new Timer();
            monitor.Interval = segundos * 1000;
            monitor.Tick += Monitor_Tick;
            monitor.Start();
        }

        private void Notificar(string message)
        {
            var client = new RestClient("https://slack.com/api/chat.postMessage");
            var request = new RestRequest(Method.POST);
            request.AddParameter("token", ConfigurationSettings.AppSettings["JeremiasToken"]);
            request.AddParameter("channel", ConfigurationSettings.AppSettings["Channel"]);
            request.AddParameter("text", message);
            request.AddParameter("as_user", "true");
            request.AddParameter("username", ConfigurationSettings.AppSettings["Username"]);
            request.AddParameter("pretty", "1");
            
            IRestResponse response = client.Execute(request);
            //var content = response.Content;
        }

        private User CapturarDadosPorIP(string ip)
        {
            string dataFile = ConfigurationSettings.AppSettings["DataFile"];
            if (!File.Exists(dataFile))
            {
                throw new Exception("Arquivo de dados não encontrado.");
            }

            var rows = new List<string[]>();
            foreach (var line in System.IO.File.ReadLines(dataFile))
            {
                var arr = line.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                rows.Add(arr);
            }
            var listaUsuarios = rows.ToArray();

            var user = listaUsuarios.FirstOrDefault(r => r[1] == $"{ip}");
            if (user == null)
                return null;

            return new User(nome: user[0], ip:user[1], slack: user[2]);
        }

        private void Monitor_Tick(object sender, EventArgs e)
        {
            var ip = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties();

            var tcpConnections = ip.GetActiveTcpConnections();
            foreach (var tcp in tcpConnections)
            {
                if (tcp.LocalEndPoint.Port == 3389 || tcp.RemoteEndPoint.Port == 3389)
                {
                    if (string.IsNullOrEmpty(IpUsando))
                    {
                        IpUsando = $"{tcp.RemoteEndPoint.Address}";
                        User user = CapturarDadosPorIP(IpUsando);
                        Notificar($"{(user != null ? user.Nome : $"{IpUsando}")} acessou o servidor {tcp.RemoteEndPoint.Address}.");
                        break;

                        //txtHistoricoGalera.Text = $"{txtHistoricoGalera.Text}{Environment.NewLine}Acessado por {tcp.RemoteEndPoint.Address}.";
                        //string urlWithAccessToken = $"https://{your_account}.slack.com/services/hooks/incoming-webhook?token={your_access_token}";

                        //SlackClient client = new SlackClient(urlWithAccessToken);
                        //client.PostMessage(
                        //    username: "Mr. Torgue",
                        //    text: "THIS IS A TEST MESSAGE! SQUEEDLYBAMBLYFEEDLYMEEDLYMOWWWWWWWW!",
                        //    channel: "#general");
                    }
                    else
                    {
                        string novoIP = $"{tcp.RemoteEndPoint.Address}";
                        if (IpUsando != novoIP)
                        {
                            User anteriorUser = CapturarDadosPorIP(IpUsando);
                            User novoUser = CapturarDadosPorIP(novoIP);
                            Notificar($"{(novoUser != null ? novoUser.Nome : $"{novoIP}")} derrubou {(anteriorUser != null ? $"@{anteriorUser.Slack}" : $"{IpUsando}")} do servidor {tcp.LocalEndPoint.Address}.");
                            IpUsando = novoIP;
                            break;
                        }
                    }
                }
            }

            if (!string.IsNullOrEmpty(IpUsando))
            {
                var tcpConnection = tcpConnections.FirstOrDefault(tcp => tcp.LocalEndPoint.Port == 3389 || tcp.RemoteEndPoint.Port == 3389);
                if (tcpConnection == null)
                {
                    string hostName = Dns.GetHostName();
                    string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();

                    User user = CapturarDadosPorIP(IpUsando);
                    Notificar($"{(user != null ? user.Nome : $"{IpUsando}")} saiu do servidor {myIP}.");
                    IpUsando = null;
                }
            }

            monitor.Start();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Valida())
                return;

            string dataFile = ConfigurationSettings.AppSettings["DataFile"];
            File.WriteAllText(dataFile, $"{txtNome.Text},{txtIP.Text},{txtSlack.Text}");
            LimpaCampos();

            MessageBox.Show("Foi! ✋");
        }
    }
}
