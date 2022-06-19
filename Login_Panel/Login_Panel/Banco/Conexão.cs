using MySql.Data.MySqlClient;

namespace Login_Panel.Banco
{
    internal class Conexão
    {
        protected static MySqlConnection? CONEXAO;
        protected static MySqlConnection CONEXAO_BANCO()
        {
            CONEXAO = new MySqlConnection(
                "server='HOST_SERVER_NAME';" +
                "database='DATABASE_NAME';" +
                "uid='DATABASE_USERNAME';" +
                "pwd='DATABASE_PASSWORD';" +
                "port='DATABASE_PORT_DEFAULT=3306'");
            CONEXAO.Open();
            return CONEXAO;
        }
    }
}
