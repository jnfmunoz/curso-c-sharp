using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Library
{
    public class TextBoxEvent
    {
        /*
         * Este método restringe los caracteres que se pueden escribir en un campo de texto,
         * permitiendo sólo letras, espacios y backspace:           
         */
        public void TextKeyPress(KeyPressEventArgs e)
        {
            // condición que sólo nos permite ingresar datos de tipo texto
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            // condición que permite no dar salto de línea cuando se oprime Enter.
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            // condición que permite uTilizar la tecla backspace
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            // condición que permite utilizar la tecla de espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            // cualquier otro carácter (números, símbolos, etc.) se bloquea
            else { e.Handled = true; }
        }

        public void NumberKeyPress(KeyPressEventArgs e)
        {
            // condición que sólo nos permite ingresar datos de tipo numérico
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            // condición que permite no dar salto de línea cuando se oprime Enter.
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            // condición que no permite ingresar datos de tipo numérico
            else if (char.IsLetter(e.KeyChar)) { e.Handled = true; }
            // condición que permite uTilizar la tecla backspace
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            // condición que permite utilizar la tecla de espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            // cualquier otro carácter (números, símbolos, etc.) se bloquea
            else { e.Handled = true; }
        }

        public bool ComprobarFormatoEmail(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }

    }
}
