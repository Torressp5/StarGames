
namespace StarGames.UI
{
    partial class FrmCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrar));
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GbxCadastro = new System.Windows.Forms.GroupBox();
            this.Gbox1 = new System.Windows.Forms.GroupBox();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelecionarImagem = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.GbxCadastro.SuspendLayout();
            this.Gbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsuario.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(25, 406);
            this.dgvUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.RowHeadersWidth = 51;
            this.dgvUsuario.RowTemplate.Height = 24;
            this.dgvUsuario.Size = new System.Drawing.Size(730, 202);
            this.dgvUsuario.TabIndex = 14;
            // 
            // btnConfirma
            // 
            this.btnConfirma.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnConfirma.Location = new System.Drawing.Point(387, 214);
            this.btnConfirma.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(90, 30);
            this.btnConfirma.TabIndex = 6;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSair.Location = new System.Drawing.Point(665, 75);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 30);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCancelar.Location = new System.Drawing.Point(293, 214);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnExcluir.Location = new System.Drawing.Point(256, 75);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 30);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAlterar.Location = new System.Drawing.Point(135, 75);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 30);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(250, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cadastro de Usuário";
            // 
            // txtNome
            // 
            this.txtNome.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtNome.Location = new System.Drawing.Point(74, 59);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(202, 26);
            this.txtNome.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(74, 26);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(48, 26);
            this.txtID.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // GbxCadastro
            // 
            this.GbxCadastro.BackColor = System.Drawing.Color.SeaGreen;
            this.GbxCadastro.Controls.Add(this.Gbox1);
            this.GbxCadastro.Controls.Add(this.txtData);
            this.GbxCadastro.Controls.Add(this.txtCpf);
            this.GbxCadastro.Controls.Add(this.picBox1);
            this.GbxCadastro.Controls.Add(this.btnSelecionarImagem);
            this.GbxCadastro.Controls.Add(this.btnConfirma);
            this.GbxCadastro.Controls.Add(this.btnCancelar);
            this.GbxCadastro.Controls.Add(this.TxtEmail);
            this.GbxCadastro.Controls.Add(this.TxtSenha);
            this.GbxCadastro.Controls.Add(this.label8);
            this.GbxCadastro.Controls.Add(this.txtNome);
            this.GbxCadastro.Controls.Add(this.label7);
            this.GbxCadastro.Controls.Add(this.txtID);
            this.GbxCadastro.Controls.Add(this.label4);
            this.GbxCadastro.Controls.Add(this.label3);
            this.GbxCadastro.Controls.Add(this.label6);
            this.GbxCadastro.Controls.Add(this.label2);
            this.GbxCadastro.Enabled = false;
            this.GbxCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxCadastro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GbxCadastro.Location = new System.Drawing.Point(25, 115);
            this.GbxCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.GbxCadastro.Name = "GbxCadastro";
            this.GbxCadastro.Padding = new System.Windows.Forms.Padding(2);
            this.GbxCadastro.Size = new System.Drawing.Size(730, 256);
            this.GbxCadastro.TabIndex = 13;
            this.GbxCadastro.TabStop = false;
            this.GbxCadastro.Text = "Cadastro";
            // 
            // Gbox1
            // 
            this.Gbox1.Controls.Add(this.rb2);
            this.Gbox1.Controls.Add(this.rb1);
            this.Gbox1.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Gbox1.Location = new System.Drawing.Point(302, 66);
            this.Gbox1.Margin = new System.Windows.Forms.Padding(2);
            this.Gbox1.Name = "Gbox1";
            this.Gbox1.Padding = new System.Windows.Forms.Padding(2);
            this.Gbox1.Size = new System.Drawing.Size(165, 85);
            this.Gbox1.TabIndex = 16;
            this.Gbox1.TabStop = false;
            this.Gbox1.Text = "Selecione a Opção desejada";
            this.Gbox1.Enter += new System.EventHandler(this.Gbox1_Enter);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb2.Location = new System.Drawing.Point(20, 55);
            this.rb2.Margin = new System.Windows.Forms.Padding(2);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(73, 17);
            this.rb2.TabIndex = 5;
            this.rb2.TabStop = true;
            this.rb2.Text = "Outros";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb1.Location = new System.Drawing.Point(20, 34);
            this.rb1.Margin = new System.Windows.Forms.Padding(2);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(129, 17);
            this.rb1.TabIndex = 4;
            this.rb1.TabStop = true;
            this.rb1.Text = "Administrador";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(194, 195);
            this.txtData.Margin = new System.Windows.Forms.Padding(2);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(82, 26);
            this.txtData.TabIndex = 10;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(74, 92);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(2);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(141, 26);
            this.txtCpf.TabIndex = 9;
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(481, 17);
            this.picBox1.Margin = new System.Windows.Forms.Padding(2);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(230, 193);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox1.TabIndex = 8;
            this.picBox1.TabStop = false;
            this.picBox1.Click += new System.EventHandler(this.picBox1_Click);
            // 
            // btnSelecionarImagem
            // 
            this.btnSelecionarImagem.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarImagem.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSelecionarImagem.Location = new System.Drawing.Point(481, 214);
            this.btnSelecionarImagem.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelecionarImagem.Name = "btnSelecionarImagem";
            this.btnSelecionarImagem.Size = new System.Drawing.Size(230, 30);
            this.btnSelecionarImagem.TabIndex = 6;
            this.btnSelecionarImagem.Text = "Selecionar Imagem";
            this.btnSelecionarImagem.UseVisualStyleBackColor = true;
            this.btnSelecionarImagem.Click += new System.EventHandler(this.btnSelecionarImagem_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TxtEmail.Location = new System.Drawing.Point(74, 126);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(202, 26);
            this.TxtEmail.TabIndex = 1;
            // 
            // TxtSenha
            // 
            this.TxtSenha.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TxtSenha.Location = new System.Drawing.Point(74, 161);
            this.TxtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSenha.MaxLength = 6;
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(202, 26);
            this.TxtSenha.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(8, 129);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(8, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(11, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data de nascimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "CPF:";
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnNovo.Location = new System.Drawing.Point(25, 75);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 30);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // FrmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(782, 622);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GbxCadastro);
            this.Controls.Add(this.btnNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastrar";
            this.Load += new System.EventHandler(this.FrmCadastrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.GbxCadastro.ResumeLayout(false);
            this.GbxCadastro.PerformLayout();
            this.Gbox1.ResumeLayout(false);
            this.Gbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GbxCadastro;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSelecionarImagem;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.GroupBox Gbox1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        public System.Windows.Forms.PictureBox picBox1;
    }
}