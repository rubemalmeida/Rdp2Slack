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

namespace Rdp2Slack
{
    public partial class Panel : MetroForm
    {
        public string Nome { get; set; }
        public string IP { get; set; }
        public string Slack { get; set; }

        public Panel()
        {
            InitializeComponent();
        }

        private void ObterDados()
        {
            Nome = txtNome.Text;
            IP = txtIP.Text;
            Slack = txtSlack.Text;
        }

        private bool Validar()
        {            
            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ObterDados();
#pragma warning disable CS0618 // Type or member is obsolete
            string configvalue1 = ConfigurationSettings.AppSettings["DataUsersFile"];
#pragma warning restore CS0618 // Type or member is obsolete
            
        }
    }
}
