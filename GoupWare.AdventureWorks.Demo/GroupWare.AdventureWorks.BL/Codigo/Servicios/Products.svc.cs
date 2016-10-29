using GroupWare.AdventureWorks.G_Repository;
using GoupWare.AdventureWorks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Entity.Framework.Warming.AdventureWorks.BL.Services
{
    /// <summary>
    /// Implementación de la interfaz con los métodos 
    /// disponibles para consultar la tabla de productos
    /// </summary>
    public class Products : IProducts
    {
        /// <summary>
        /// Obtiene un listado de los productos cuyo color sea 
        /// similar al patrón establecido.
        /// </summary>
        /// <param name="colorPattern">patrón de consulta de 
        /// color.  Puede contener únicamente una parte del 
        /// nombre del color.</param>
        /// <returns>lista de productos que cumplen con la 
        /// condición.</returns>
        public IQueryable<Product> ListProductsByColor(string colorPattern)
        {
            var action = new Actions.Products();
            var resultado = action.ListProductsByColor(colorPattern);
            return (resultado);
        }


        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
