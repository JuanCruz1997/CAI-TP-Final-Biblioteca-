using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Biblioteca
{
    public interface IForm
    {

        bool MessageOkCancel(string msg, string tituloForm);
        void CloseWindow();
        void Tab();

        void ValidarCampos();


        void LimpiarCampos();


        void CompletarFormulario();
        
        void FormatearCampos(string condicion);
        

      


    }
}
