using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalizarErrorProviter
{
    public partial class ErrorProviterEmail: TextBox
    {
        public ErrorProviterEmail()
        {
            InitializeComponent();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            //Si la funcion devuelte falso el fondo del textbox es rojo, cuando devuelve true se pinta de verde
            if (!ValidarEmail(this.Text))
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.Green;
            }
        }

        //Funcion que valida que email contenga una @ y un ., devuelve true cuando se cumple
        private bool ValidarEmail(string email)
        {
            if (email.Length == 0)
            {
                return false;
            }

            if (email.IndexOf("@") > -1)
            {
                if (email.IndexOf(".", email.IndexOf("@")) > email.IndexOf("@"))
                {
                    return true;
                }
            }
            return false;

            throw new NotImplementedException();
        }
    }
}
