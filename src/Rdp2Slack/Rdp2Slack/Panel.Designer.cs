namespace Rdp2Slack
{
    partial class Panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tabPanel = new MetroFramework.Controls.MetroTabControl();
            this.mTabPageCadastro = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtHistoricoIndividual = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtSlack = new MetroFramework.Controls.MetroTextBox();
            this.lblSlack = new MetroFramework.Controls.MetroLabel();
            this.chkEnviarNotificacao = new MetroFramework.Controls.MetroCheckBox();
            this.chkReceberNotificacao = new MetroFramework.Controls.MetroCheckBox();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.txtIP = new MetroFramework.Controls.MetroTextBox();
            this.lblIP = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.mTabPageLista = new MetroFramework.Controls.MetroTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.tabPanel.SuspendLayout();
            this.mTabPageCadastro.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.mTabPageCadastro);
            this.tabPanel.Controls.Add(this.mTabPageLista);
            this.tabPanel.Location = new System.Drawing.Point(24, 64);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(585, 272);
            this.tabPanel.TabIndex = 0;
            // 
            // mTabPageCadastro
            // 
            this.mTabPageCadastro.Controls.Add(this.metroPanel2);
            this.mTabPageCadastro.HorizontalScrollbarBarColor = true;
            this.mTabPageCadastro.Location = new System.Drawing.Point(4, 35);
            this.mTabPageCadastro.Name = "mTabPageCadastro";
            this.mTabPageCadastro.Size = new System.Drawing.Size(577, 233);
            this.mTabPageCadastro.TabIndex = 0;
            this.mTabPageCadastro.Text = "Cadastro";
            this.mTabPageCadastro.VerticalScrollbarBarColor = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroPanel3);
            this.metroPanel2.Controls.Add(this.metroPanel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 4);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(571, 226);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroLabel1);
            this.metroPanel3.Controls.Add(this.txtHistoricoIndividual);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(317, 3);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(251, 220);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Histórico:";
            // 
            // txtHistoricoIndividual
            // 
            this.txtHistoricoIndividual.Location = new System.Drawing.Point(3, 22);
            this.txtHistoricoIndividual.Multiline = true;
            this.txtHistoricoIndividual.Name = "txtHistoricoIndividual";
            this.txtHistoricoIndividual.ReadOnly = true;
            this.txtHistoricoIndividual.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistoricoIndividual.Size = new System.Drawing.Size(245, 195);
            this.txtHistoricoIndividual.TabIndex = 2;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.txtSlack);
            this.metroPanel1.Controls.Add(this.lblSlack);
            this.metroPanel1.Controls.Add(this.chkEnviarNotificacao);
            this.metroPanel1.Controls.Add(this.chkReceberNotificacao);
            this.metroPanel1.Controls.Add(this.btnExcluir);
            this.metroPanel1.Controls.Add(this.btnSalvar);
            this.metroPanel1.Controls.Add(this.txtIP);
            this.metroPanel1.Controls.Add(this.lblIP);
            this.metroPanel1.Controls.Add(this.txtNome);
            this.metroPanel1.Controls.Add(this.lblNome);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(308, 220);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtSlack
            // 
            this.txtSlack.Location = new System.Drawing.Point(205, 22);
            this.txtSlack.Name = "txtSlack";
            this.txtSlack.Size = new System.Drawing.Size(100, 23);
            this.txtSlack.TabIndex = 11;
            // 
            // lblSlack
            // 
            this.lblSlack.AutoSize = true;
            this.lblSlack.Location = new System.Drawing.Point(205, 0);
            this.lblSlack.Name = "lblSlack";
            this.lblSlack.Size = new System.Drawing.Size(41, 19);
            this.lblSlack.TabIndex = 10;
            this.lblSlack.Text = "Slack:";
            // 
            // chkEnviarNotificacao
            // 
            this.chkEnviarNotificacao.AutoSize = true;
            this.chkEnviarNotificacao.Location = new System.Drawing.Point(4, 74);
            this.chkEnviarNotificacao.Name = "chkEnviarNotificacao";
            this.chkEnviarNotificacao.Size = new System.Drawing.Size(232, 15);
            this.chkEnviarNotificacao.TabIndex = 9;
            this.chkEnviarNotificacao.Text = "Notificar diretamente a quem derrubar?";
            this.chkEnviarNotificacao.UseVisualStyleBackColor = true;
            // 
            // chkReceberNotificacao
            // 
            this.chkReceberNotificacao.AutoSize = true;
            this.chkReceberNotificacao.Location = new System.Drawing.Point(4, 52);
            this.chkReceberNotificacao.Name = "chkReceberNotificacao";
            this.chkReceberNotificacao.Size = new System.Drawing.Size(287, 15);
            this.chkReceberNotificacao.TabIndex = 8;
            this.chkReceberNotificacao.Text = "Receber notificação direta quando te derrubarem?";
            this.chkReceberNotificacao.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(157, 95);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(148, 23);
            this.btnExcluir.Style = MetroFramework.MetroColorStyle.Red;
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(3, 95);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(148, 23);
            this.btnSalvar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(110, 22);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(89, 23);
            this.txtIP.TabIndex = 5;
            this.txtIP.Text = "171.171.171.171";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(110, 0);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(23, 19);
            this.lblIP.TabIndex = 4;
            this.lblIP.Text = "IP:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(3, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(101, 23);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(3, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 19);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // mTabPageLista
            // 
            this.mTabPageLista.HorizontalScrollbarBarColor = true;
            this.mTabPageLista.Location = new System.Drawing.Point(4, 35);
            this.mTabPageLista.Name = "mTabPageLista";
            this.mTabPageLista.Size = new System.Drawing.Size(577, 233);
            this.mTabPageLista.TabIndex = 1;
            this.mTabPageLista.Text = "Lista";
            this.mTabPageLista.VerticalScrollbarBarColor = true;
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 359);
            this.Controls.Add(this.tabPanel);
            this.MaximizeBox = false;
            this.Name = "Panel";
            this.Resizable = false;
            this.Text = "Rdp2Slack";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.tabPanel.ResumeLayout(false);
            this.mTabPageCadastro.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTabControl tabPanel;
        private MetroFramework.Controls.MetroTabPage mTabPageCadastro;
        private MetroFramework.Controls.MetroTabPage mTabPageLista;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtHistoricoIndividual;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private MetroFramework.Controls.MetroTextBox txtIP;
        private MetroFramework.Controls.MetroLabel lblIP;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroCheckBox chkEnviarNotificacao;
        private MetroFramework.Controls.MetroCheckBox chkReceberNotificacao;
        private MetroFramework.Controls.MetroTextBox txtSlack;
        private MetroFramework.Controls.MetroLabel lblSlack;
    }
}