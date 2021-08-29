
namespace StarGames
{
    partial class FrmMainUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Relátorio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Calculadora = new System.Windows.Forms.ToolStripButton();
            this.Word = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Sair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lblSession = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.relátorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitarios = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 800);
            this.panel1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.ForestGreen;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Relátorio,
            this.toolStripSeparator1,
            this.Calculadora,
            this.Word,
            this.toolStripSeparator3,
            this.Sair,
            this.toolStripSeparator4,
            this.lblSession});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1201, 57);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Relátorio
            // 
            this.Relátorio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Relátorio.Image = global::StarGames.Properties.Resources.chart_128x128;
            this.Relátorio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Relátorio.Name = "Relátorio";
            this.Relátorio.Size = new System.Drawing.Size(54, 54);
            this.Relátorio.Text = "Relátorio";
            this.Relátorio.Click += new System.EventHandler(this.Relátorio_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // Calculadora
            // 
            this.Calculadora.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Calculadora.Image = global::StarGames.Properties.Resources.calculator_128x128;
            this.Calculadora.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Calculadora.Name = "Calculadora";
            this.Calculadora.Size = new System.Drawing.Size(54, 54);
            this.Calculadora.Text = "Calculadora";
            this.Calculadora.Click += new System.EventHandler(this.Calculadora_Click);
            // 
            // Word
            // 
            this.Word.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Word.Image = global::StarGames.Properties.Resources.Logo_Microsoft_Word_2013;
            this.Word.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(54, 54);
            this.Word.Text = "Word";
            this.Word.Click += new System.EventHandler(this.Word_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 57);
            // 
            // Sair
            // 
            this.Sair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Sair.Image = global::StarGames.Properties.Resources.Sair;
            this.Sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(54, 54);
            this.Sair.Text = "Sair";
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 57);
            // 
            // lblSession
            // 
            this.lblSession.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSession.ForeColor = System.Drawing.Color.LightGreen;
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(158, 54);
            this.lblSession.Text = "toolStripLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relátorioToolStripMenuItem,
            this.utilitarios,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1201, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // relátorioToolStripMenuItem
            // 
            this.relátorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem});
            this.relátorioToolStripMenuItem.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relátorioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.relátorioToolStripMenuItem.Name = "relátorioToolStripMenuItem";
            this.relátorioToolStripMenuItem.Size = new System.Drawing.Size(103, 21);
            this.relátorioToolStripMenuItem.Text = "&Relátorio";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.usuárioToolStripMenuItem.Text = "&Jogos";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // utilitarios
            // 
            this.utilitarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem1,
            this.wordToolStripMenuItem1});
            this.utilitarios.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilitarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.utilitarios.Name = "utilitarios";
            this.utilitarios.Size = new System.Drawing.Size(121, 21);
            this.utilitarios.Text = "&Utilitários";
            // 
            // calculadoraToolStripMenuItem1
            // 
            this.calculadoraToolStripMenuItem1.Name = "calculadoraToolStripMenuItem1";
            this.calculadoraToolStripMenuItem1.Size = new System.Drawing.Size(189, 26);
            this.calculadoraToolStripMenuItem1.Text = "&Calculadora";
            this.calculadoraToolStripMenuItem1.Click += new System.EventHandler(this.calculadoraToolStripMenuItem1_Click);
            // 
            // wordToolStripMenuItem1
            // 
            this.wordToolStripMenuItem1.Name = "wordToolStripMenuItem1";
            this.wordToolStripMenuItem1.Size = new System.Drawing.Size(189, 26);
            this.wordToolStripMenuItem1.Text = "&Word";
            this.wordToolStripMenuItem1.Click += new System.EventHandler(this.wordToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem1});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(58, 21);
            this.toolStripMenuItem1.Text = "&Sair";
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(126, 26);
            this.sairToolStripMenuItem1.Text = "&Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // FrmMainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMainUser";
            this.Text = "FrmMainUser";
            this.Load += new System.EventHandler(this.FrmMainUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Relátorio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Calculadora;
        private System.Windows.Forms.ToolStripButton Word;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Sair;
        private System.Windows.Forms.ToolStripLabel lblSession;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem relátorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem utilitarios;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
    }
}