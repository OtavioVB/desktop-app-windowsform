namespace Login_Panel
{
    public partial class Login : Form
    {
        int TENTATIVAS_DE_LOGIN = 0;
        int TEMPO_ESPERA = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void BTN_LOGAR_Click(object sender, EventArgs e)
        {
            if (TENTATIVAS_DE_LOGIN < 5)
            {
                if (Componentes.VERIFICAR_SE_TODOS_OS_TEXTBOX_ESTAO_PREENCHIDOS(TB_NOME_DE_USUARIO, TB_SENHA) == true)
                {
                    if (Componentes.VERIFICAR_SE_TEXTBOX_SENHA_POSSUI_A_QUANTIDADE_MINIMA_DE_CARACTERES(TB_SENHA) == true && Componentes.VERIFICAR_SE_TEXTBOX_NOME_DE_USUARIO_POSSUI_A_QUANTIDADE_MINIMA_DE_CARACTERES(TB_NOME_DE_USUARIO))
                    {
                        if (Texto.VERIFICAR_SE_TEXTO_POSSUI_CONJUNTO_DE_CARACTERES_MALICIOSOS(TB_NOME_DE_USUARIO.Text) == false)
                        {

                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Os dados inseridos são inválidos, tente novamente", "Tente Novamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    TB_NOME_DE_USUARIO.Focus();
                    MessageBox.Show("Nem todos os campos estão preenchidos!", "Tente Novamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // CHAMAR FUNÇÃO DO BANCO
                TB_NOME_DE_USUARIO.Enabled = false;
                TB_SENHA.Enabled = false;
                BTN_LOGAR.Enabled = false;
                LABEL_TIME.Visible = true;
                timerEspera.Start();
                MessageBox.Show("Você já tentou logar 5 vezes e não obteve êxito, espere um minuto antes de tentar novamente");
            }
            TENTATIVAS_DE_LOGIN++;
        }

        private void TB_NOME_DE_USUARIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            Eventos.PERMITIR_APENAS_LETRAS(e);
        }

        private void TB_SENHA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Eventos.PERMITIR_APENAS_NUMEROS(e);
        }

        private void timerEspera_Tick(object sender, EventArgs e)
        {
            if (TEMPO_ESPERA <= 60)
            {
                TEMPO_ESPERA++;
                LABEL_TIME.Text = TEMPO_ESPERA.ToString();
            }
            else
            {
                TEMPO_ESPERA = 0;
                TENTATIVAS_DE_LOGIN = 0;
                TB_NOME_DE_USUARIO.Enabled = true;
                TB_SENHA.Enabled = true;
                BTN_LOGAR.Enabled = true;
                LABEL_TIME.Visible = false;
                timerEspera.Stop();
            }
        }
    }
}