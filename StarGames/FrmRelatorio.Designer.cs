
namespace StarGames
{
    partial class FrmRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorio));
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExibirRegistro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Cursor = System.Windows.Forms.Cursors.No;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv1.Location = new System.Drawing.Point(0, 100);
            this.dgv1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(1000, 401);
            this.dgv1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 100);
            this.panel1.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.DarkGreen;
            this.lblTitulo.Font = new System.Drawing.Font("OCR A Extended", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(37, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(870, 69);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Consulta de Relátorio";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.btnRelatorio);
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Controls.Add(this.btnExibirRegistro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(0, 501);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 100);
            this.panel2.TabIndex = 5;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRelatorio.Location = new System.Drawing.Point(65, 34);
            this.btnRelatorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(187, 37);
            this.btnRelatorio.TabIndex = 0;
            this.btnRelatorio.Text = "Gerar PDF";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSair.Location = new System.Drawing.Point(737, 34);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(187, 37);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExibirRegistro
            // 
            this.btnExibirRegistro.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirRegistro.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnExibirRegistro.Location = new System.Drawing.Point(408, 34);
            this.btnExibirRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExibirRegistro.Name = "btnExibirRegistro";
            this.btnExibirRegistro.Size = new System.Drawing.Size(187, 37);
            this.btnExibirRegistro.TabIndex = 1;
            this.btnExibirRegistro.Text = "Exibir Registro";
            this.btnExibirRegistro.UseVisualStyleBackColor = true;
            this.btnExibirRegistro.Click += new System.EventHandler(this.btnExibirRegistro_Click);
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 601);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRelatorio";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExibirRegistro;
    }
}