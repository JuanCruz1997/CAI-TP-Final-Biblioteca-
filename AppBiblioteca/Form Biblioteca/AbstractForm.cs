using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Biblioteca
{
    public abstract class AbstractForm<T> : Form
    {
        public abstract Form GetForm();
        
        public bool MessageOkCancel(string msg, string tituloForm)
        {

            DialogResult result = MessageBox.Show(msg, tituloForm, MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                return true;
            }
            else return false;
        }
        public void CloseWindow()
        {
            GetForm().Owner.Show();
            GetForm().Dispose();
        }
        public abstract void Tab();


        public virtual void LimpiarCampos()
        {
            throw new NotImplementedException();
        }
        public virtual void LimpiarCampos(string obj)
        {
            throw new NotImplementedException();
        }


        public abstract void FormatearCampos(string condicion);

        public virtual void ValidarCampos()
        {
            throw new NotImplementedException();
        }
        public virtual void ValidarCampos(string obj)
        {
            throw new NotImplementedException();
        }
        public abstract void CompletarFormulario(T seleccionado);
        

    }
}
