namespace Login_Panel.Métodos.Tratamento_de_Componentes
{
    internal class Componentes
    {
        public static bool VERIFICAR_SE_TODOS_OS_TEXTBOX_ESTAO_PREENCHIDOS(params TextBox[] Componentes)
        {
            foreach (TextBox Componente in Componentes)
            {
                if (Componente.Text == String.Empty)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool VERIFICAR_SE_TEXTBOX_SENHA_POSSUI_A_QUANTIDADE_MINIMA_DE_CARACTERES(params TextBox[] Componentes)
        {
            foreach (TextBox Componente in Componentes)
            {
                if (Componente.TextLength < 6)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool VERIFICAR_SE_TEXTBOX_NOME_DE_USUARIO_POSSUI_A_QUANTIDADE_MINIMA_DE_CARACTERES(params TextBox[] Componentes)
        {
            foreach (TextBox Componente in Componentes)
            {
                if (Componente.TextLength < 4)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
