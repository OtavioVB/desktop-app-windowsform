namespace Login_Panel
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PANEL_TOP = new System.Windows.Forms.Panel();
            this.LABEL_TITLE = new System.Windows.Forms.Label();
            this.PANEL_MAIN = new System.Windows.Forms.Panel();
            this.PB_LOGO_DA_EMPRESA = new System.Windows.Forms.PictureBox();
            this.BTN_LOGAR = new System.Windows.Forms.Button();
            this.TB_SENHA = new System.Windows.Forms.TextBox();
            this.TB_NOME_DE_USUARIO = new System.Windows.Forms.TextBox();
            this.LABEL_SENHA = new System.Windows.Forms.Label();
            this.LABEL_NOME_DE_USUARIO = new System.Windows.Forms.Label();
            this.timerEspera = new System.Windows.Forms.Timer(this.components);
            this.LABEL_TIME = new System.Windows.Forms.Label();
            this.PANEL_TOP.SuspendLayout();
            this.PANEL_MAIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_LOGO_DA_EMPRESA)).BeginInit();
            this.SuspendLayout();
            // 
            // PANEL_TOP
            // 
            this.PANEL_TOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(77)))));
            this.PANEL_TOP.Controls.Add(this.LABEL_TIME);
            this.PANEL_TOP.Controls.Add(this.LABEL_TITLE);
            this.PANEL_TOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.PANEL_TOP.Location = new System.Drawing.Point(0, 0);
            this.PANEL_TOP.Name = "PANEL_TOP";
            this.PANEL_TOP.Size = new System.Drawing.Size(800, 40);
            this.PANEL_TOP.TabIndex = 0;
            // 
            // LABEL_TITLE
            // 
            this.LABEL_TITLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LABEL_TITLE.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LABEL_TITLE.ForeColor = System.Drawing.Color.White;
            this.LABEL_TITLE.Location = new System.Drawing.Point(12, 0);
            this.LABEL_TITLE.Name = "LABEL_TITLE";
            this.LABEL_TITLE.Size = new System.Drawing.Size(595, 40);
            this.LABEL_TITLE.TabIndex = 1;
            this.LABEL_TITLE.Text = "Área de Login";
            this.LABEL_TITLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PANEL_MAIN
            // 
            this.PANEL_MAIN.Controls.Add(this.PB_LOGO_DA_EMPRESA);
            this.PANEL_MAIN.Controls.Add(this.BTN_LOGAR);
            this.PANEL_MAIN.Controls.Add(this.TB_SENHA);
            this.PANEL_MAIN.Controls.Add(this.TB_NOME_DE_USUARIO);
            this.PANEL_MAIN.Controls.Add(this.LABEL_SENHA);
            this.PANEL_MAIN.Controls.Add(this.LABEL_NOME_DE_USUARIO);
            this.PANEL_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_MAIN.Location = new System.Drawing.Point(0, 40);
            this.PANEL_MAIN.Name = "PANEL_MAIN";
            this.PANEL_MAIN.Size = new System.Drawing.Size(800, 189);
            this.PANEL_MAIN.TabIndex = 1;
            // 
            // PB_LOGO_DA_EMPRESA
            // 
            this.PB_LOGO_DA_EMPRESA.Location = new System.Drawing.Point(317, 0);
            this.PB_LOGO_DA_EMPRESA.Name = "PB_LOGO_DA_EMPRESA";
            this.PB_LOGO_DA_EMPRESA.Size = new System.Drawing.Size(483, 189);
            this.PB_LOGO_DA_EMPRESA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_LOGO_DA_EMPRESA.TabIndex = 7;
            this.PB_LOGO_DA_EMPRESA.TabStop = false;
            // 
            // BTN_LOGAR
            // 
            this.BTN_LOGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(77)))));
            this.BTN_LOGAR.FlatAppearance.BorderSize = 0;
            this.BTN_LOGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LOGAR.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_LOGAR.ForeColor = System.Drawing.Color.White;
            this.BTN_LOGAR.Location = new System.Drawing.Point(12, 146);
            this.BTN_LOGAR.Name = "BTN_LOGAR";
            this.BTN_LOGAR.Size = new System.Drawing.Size(282, 29);
            this.BTN_LOGAR.TabIndex = 6;
            this.BTN_LOGAR.Text = "LOGAR";
            this.BTN_LOGAR.UseVisualStyleBackColor = false;
            this.BTN_LOGAR.Click += new System.EventHandler(this.BTN_LOGAR_Click);
            // 
            // TB_SENHA
            // 
            this.TB_SENHA.Location = new System.Drawing.Point(12, 103);
            this.TB_SENHA.Name = "TB_SENHA";
            this.TB_SENHA.PasswordChar = '*';
            this.TB_SENHA.PlaceholderText = "Senha";
            this.TB_SENHA.Size = new System.Drawing.Size(282, 23);
            this.TB_SENHA.TabIndex = 5;
            this.TB_SENHA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_SENHA_KeyPress);
            // 
            // TB_NOME_DE_USUARIO
            // 
            this.TB_NOME_DE_USUARIO.Location = new System.Drawing.Point(12, 42);
            this.TB_NOME_DE_USUARIO.Name = "TB_NOME_DE_USUARIO";
            this.TB_NOME_DE_USUARIO.PlaceholderText = "Nome de usuário";
            this.TB_NOME_DE_USUARIO.Size = new System.Drawing.Size(282, 23);
            this.TB_NOME_DE_USUARIO.TabIndex = 4;
            this.TB_NOME_DE_USUARIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_NOME_DE_USUARIO_KeyPress);
            // 
            // LABEL_SENHA
            // 
            this.LABEL_SENHA.BackColor = System.Drawing.SystemColors.Control;
            this.LABEL_SENHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LABEL_SENHA.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LABEL_SENHA.ForeColor = System.Drawing.Color.Black;
            this.LABEL_SENHA.Location = new System.Drawing.Point(12, 77);
            this.LABEL_SENHA.Name = "LABEL_SENHA";
            this.LABEL_SENHA.Size = new System.Drawing.Size(282, 23);
            this.LABEL_SENHA.TabIndex = 3;
            this.LABEL_SENHA.Text = "Senha";
            this.LABEL_SENHA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LABEL_NOME_DE_USUARIO
            // 
            this.LABEL_NOME_DE_USUARIO.BackColor = System.Drawing.SystemColors.Control;
            this.LABEL_NOME_DE_USUARIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LABEL_NOME_DE_USUARIO.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LABEL_NOME_DE_USUARIO.ForeColor = System.Drawing.Color.Black;
            this.LABEL_NOME_DE_USUARIO.Location = new System.Drawing.Point(12, 16);
            this.LABEL_NOME_DE_USUARIO.Name = "LABEL_NOME_DE_USUARIO";
            this.LABEL_NOME_DE_USUARIO.Size = new System.Drawing.Size(282, 23);
            this.LABEL_NOME_DE_USUARIO.TabIndex = 2;
            this.LABEL_NOME_DE_USUARIO.Text = "Nome de Usuário";
            this.LABEL_NOME_DE_USUARIO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerEspera
            // 
            this.timerEspera.Interval = 1000;
            this.timerEspera.Tick += new System.EventHandler(this.timerEspera_Tick);
            // 
            // LABEL_TIME
            // 
            this.LABEL_TIME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LABEL_TIME.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LABEL_TIME.ForeColor = System.Drawing.Color.White;
            this.LABEL_TIME.Location = new System.Drawing.Point(716, 3);
            this.LABEL_TIME.Name = "LABEL_TIME";
            this.LABEL_TIME.Size = new System.Drawing.Size(84, 37);
            this.LABEL_TIME.TabIndex = 2;
            this.LABEL_TIME.Text = "0";
            this.LABEL_TIME.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LABEL_TIME.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 229);
            this.Controls.Add(this.PANEL_MAIN);
            this.Controls.Add(this.PANEL_TOP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.Text = "Painel de Login";
            this.PANEL_TOP.ResumeLayout(false);
            this.PANEL_MAIN.ResumeLayout(false);
            this.PANEL_MAIN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_LOGO_DA_EMPRESA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PANEL_TOP;
        private Label LABEL_TITLE;
        private Panel PANEL_MAIN;
        private PictureBox PB_LOGO_DA_EMPRESA;
        private Button BTN_LOGAR;
        private TextBox TB_SENHA;
        private TextBox TB_NOME_DE_USUARIO;
        private Label LABEL_SENHA;
        private Label LABEL_NOME_DE_USUARIO;
        private System.Windows.Forms.Timer timerEspera;
        private Label LABEL_TIME;
    }
}