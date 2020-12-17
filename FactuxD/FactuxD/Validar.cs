using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms; //Para heredar las propiedades de un Form

namespace FactuxD
{
    class Validar
    {

        public static Boolean ValidarFormulario(Control Objeto, ErrorProvider ErrorProvider)//Objeto en el que se trabaja, ErrorProvider
        {

            Boolean HayErrores = false; //Por defecto no hay errores. 

            foreach (Control Item in Objeto.Controls)   //Por cada objeto (ErrorTxtBox) hara lo siguiente.
            {
                if (Item is ErrorTxtBox)  //Si el objeto en el que trabaja es un ErrorTxtBox
                {
                    ErrorTxtBox Obj = (ErrorTxtBox)Item;  //Se instancia un objeto tipo ErrorTxtBox

                    if (Obj.Validar == true)  //Verifica su su propiedad Validar esta encendida o apagada.
                    {

                        if (string.IsNullOrEmpty(Obj.Text.Trim()))  //Si la cadena esta vacia o nula de el objeto en su propiedad .Text
                        {
                            ErrorProvider.SetError(Obj, "No puede estar vacio.");  //Muestra el mensaje en el ErrorProvider
                            HayErrores = true;  //Se cambia a true ya que si hay errores.
                        }
                    }

                    if(Obj.SoloNumeros == true)
                    {
                        int cont = 0, LetrasEncontradas = 0;

                        foreach(char letra in Obj.Text.Trim())
                        {
                            if (char.IsLetter(Obj.Text.Trim(), cont))
                            {
                                LetrasEncontradas++;
                            }

                            cont++;

                        }

                        if(LetrasEncontradas != 0)
                        {
                            HayErrores = true;
                            ErrorProvider.SetError(Obj, "Solo numeros");
                        }

                    }

                }

            }

            return HayErrores;  //Regresa el valor de HayErrores.

        }

    }
}
