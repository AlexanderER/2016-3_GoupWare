using GoupWare.AdventureWorks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Framework.Warming.AdventureWorks.BL.Actions
{
    public class Products
    {
        /// <summary>
        /// contexto de conexión con la base de datos.
        /// </summary>
        private readonly AdventureWorks2014Entities _context =
            new AdventureWorks2014Entities();

        private string _includeProperties = "ProductModel, ProductSubcategory";

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
            var repository = new Repositories.Products(_context);
            var resultado = repository.ProductsByColor(colorPattern);
            return (resultado);
        }
    }
}
