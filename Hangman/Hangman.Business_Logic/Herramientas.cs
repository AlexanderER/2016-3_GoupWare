using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Business_Logic
{
    public class Herramientas
    {
        public Boolean UnaLetraEstaContenidaEnUnaPalabra(Char p_cLetra, String p_sPalabra)
        {
            Boolean bElResultado;

            bElResultado = p_sPalabra.ToUpper().Contains(Convert.ToString(p_cLetra).ToUpper());

            return bElResultado;
        }


    }
}
