using MySql.Data.MySqlClient;

namespace Login_Panel.Banco.Autenticação
{
    internal class BancoAutenticação : Conexão
    {
        public static bool VERIFICAR_SE_DADOS_INSERIDOS_LOGIN_ESTAO_CORRETOS(string NomeDeUsuario, string Senha)
        {
            try
            {
                return false;
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
