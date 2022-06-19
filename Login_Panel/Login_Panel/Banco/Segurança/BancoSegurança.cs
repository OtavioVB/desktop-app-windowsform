using MySql.Data.MySqlClient;

namespace Login_Panel.Banco.Segurança
{
    internal class BancoSegurança : Conexão
    {
        /*
         * TABELA DE SEGURANÇA
         * 
         * TB_USUARIO_MALICIOSO (
         * N_ID INTEGER PRIMARY KEY AUTO_INCREMENT, 
         * T_IP_USUARIO VARCHAR(50), 
         * T_COMANDO_EXECUTADO VARCHAR(200)
         * )
         * 
         */
        public static void INSERIR_DADOS_DE_USUARIO_MALICIOSO_NO_BANCO(string IPDOUsuario, string COMANDOEXECUTADO)
        {
            try
            {
                using (MySqlCommand Comando = CONEXAO_BANCO().CreateCommand())
                {
                    Comando.CommandText = "INSERT INTO TB_USUARIO_MALICIOSO (T_IP_USUARIO, T_COMANDO_EXECUTADO) VALUES " +
                        "(@IPDOUsuario, @COMANDOExecutado)";
                    Comando.Parameters.AddWithValue("@IPDOUsuario", IPDOUsuario);
                    Comando.Parameters.AddWithValue("@COMANDOEXECUTADO", COMANDOEXECUTADO);
                    Comando.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                CONEXAO_BANCO().Close();
            }
        }
    }
}
