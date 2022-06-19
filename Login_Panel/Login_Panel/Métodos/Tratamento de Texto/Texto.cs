using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Panel.Métodos.Tratamento_de_Texto
{
    internal class Texto
    {
        public static bool VERIFICAR_SE_TEXTO_POSSUI_CONJUNTO_DE_CARACTERES_MALICIOSOS(string Texto)
        {
            if (Texto.Contains("<script>") == true)
            {
                // CHAMAR MÉTODO BANCO DE DADOS BLACKLIST
                return true;
            }
            else if (Texto.Contains("DROP TABLE") == true)
            {
                // CHAMAR MÉTODO BANCO DE DADOS BLACKLIST
                return true;
            }
            else if (Texto.Contains("SELECT") == true)
            {
                // CHAMAR MÉTODO BANCO DE DADOS BLACKLIST
                return true;
            }
            else if(Texto.Contains("INSERT") == true)
            {
                // CHAMAR MÉTODO BANCO DE DADOS BLACKLIST
                return true;
            }
            else if (Texto.Contains("UPDATE") == true)
            {
                // CHAMAR MÉTODO BANCO DE DADOS BLACKLIST
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
