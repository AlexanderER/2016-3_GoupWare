using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoupWare.AdventureWorks.Model
{
    public partial class Product
    {
        public Double Antiguedad { get
                                    {
                                        Double Antiguedad = 0.0;
                                        DateTime? miFechaFinal = DateTime.Now;

                                        if (DiscontinuedDate != null)
                                        {
                                            miFechaFinal = DiscontinuedDate;
                                        }

                                        TimeSpan ts = (TimeSpan)(miFechaFinal - SellStartDate);
                                        Antiguedad = ts.Days;

                                        return Antiguedad;
                                    }
                                }

        //--------------------------------------------------------------------------------------------------

        public Double WeightInKilos {
                                        get {
                                                Double dPesoEnKilos = 0.0;

                                                if (Weight != null)
                                                    {
                                                        switch (WeightUnitMeasureCode)
                                                        {
                                                            case "G":
                                                                dPesoEnKilos = (Convert.ToDouble(Weight) / 1000);
                                                                break;

                                                            case "LB":
                                                                dPesoEnKilos = (Convert.ToDouble(Weight) / 2.20462);
                                                                break;

                                                            case "NULL":
                                                                dPesoEnKilos = Convert.ToDouble(Weight);
                                                                break;
                                                        }
                                                    }                                

                                                return dPesoEnKilos;
                                            }
                                    }




    }
}
