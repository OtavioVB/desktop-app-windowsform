using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Panel.Métodos.Tratamento_de_Eventos
{
    internal class Eventos
    {
        public static void PERMITIR_APENAS_NUMEROS(KeyPressEventArgs Event)
        {
            if (!char.IsNumber(Event.KeyChar) == true && Event.KeyChar != 8 && Event.KeyChar != 13 && Event.KeyChar != 32)
            {
                Event.Handled = true;
            }
        }

        public static void PERMITIR_APENAS_LETRAS(KeyPressEventArgs Event)
        {
            if (!char.IsLetter(Event.KeyChar) == true && Event.KeyChar != 8 && Event.KeyChar != 13 && Event.KeyChar != 32)
            {
                Event.Handled = true;
            }
        }
    }
}
