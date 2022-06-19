using MySql.Data.MySqlClient;

namespace Login_Panel.Banco
{
    internal class Conexão
    {
        protected static MySqlConnection? CONEXAO;
        protected static MySqlConnection CONEXAO_BANCO()
        {
            try{
                CONEXAO = new MySqlConnection(
                    "server='HOST_SERVER_NAME';" +
                    "database='DATABASE_NAME';" +
                    "uid='DATABASE_USERNAME';" +
                    "pwd='DATABASE_PASSWORD';" +
                    "port='DATABASE_PORT_DEFAULT=3306'");
                CONEXAO.Open();
                return CONEXAO;
            }
            catch
            {
                throw;
                MessageBox.Show("Não há conexão com a internet, o aplicativo será encerrado, tente novamente mais tarde. Caso o problema persistir, entre em contato com a equipe de suporte.", "Tente novamente, mais tarde", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}
