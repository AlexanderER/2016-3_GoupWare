using System;
using System.Collections.Generic;
using System.Data;
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

        public DataSet ObtenerIndicesLetraEnPalabra(Char p_cLetra, String p_sPalabra)
        {
            // Construyo el dataSet y la Tabla con las columnas
            DataSet dsIndices = new DataSet();
            DataTable dtIndicesLetra = dsIndices.Tables.Add("dtIndices");
            dtIndicesLetra.Columns.Add("Letra");
            dtIndicesLetra.Columns.Add("Indice");


            Int32 iIndiceLetra = 0;

            foreach (Char cLetra in p_sPalabra)
            {
                if (cLetra == p_cLetra)
                {
                    DataRow myRow   = dsIndices.Tables[0].NewRow(); 
                    myRow["Letra"]  = p_cLetra.ToString();
                    myRow["Indice"] = iIndiceLetra.ToString();
                    dsIndices.Tables[0].Rows.Add(myRow);
                }

                iIndiceLetra++;
            }


            return dsIndices;
        }

    //    public void ObtenerLineas()
    //    {
    //        foreach (DataRow rowlinea in ds_________.Tables[0].Rows)
    //        {
    //            String sLicencia = rowlinea["LICENCIA"].ToString();
    //        }
    //}

}
