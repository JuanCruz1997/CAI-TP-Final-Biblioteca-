using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Biblioteca
{
    public abstract partial class AbstractForm<T> : Form
    {

        //public AbstractForm<T>()
        //{
        //    InitializeComponent();
        //}
        public virtual Form GetForm()
        {
            throw new NotImplementedException();
        }

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
        public virtual void Tab()
        {
            throw new NotImplementedException();
        }


        public virtual void LimpiarCampos()
        {
            throw new NotImplementedException();
        }
        public virtual void LimpiarCampos(string obj)
        {
            throw new NotImplementedException();
        }


        public virtual void FormatearCampos(string condicion)
        {
            throw new NotImplementedException();
        }

        public virtual void ValidarCampos()
        {
            throw new NotImplementedException();
        }
        public virtual void ValidarCampos(string obj)
        {
            throw new NotImplementedException();
        }
        public virtual void CompletarFormulario(T seleccionado)
        {
            throw new NotImplementedException();
        }


    }
}

