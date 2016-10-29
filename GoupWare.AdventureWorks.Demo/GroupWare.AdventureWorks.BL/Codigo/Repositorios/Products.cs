using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoupWare.AdventureWorks.Model;
using GroupWare.AdventureWorks.G_Repository.Services;

namespace Entity.Framework.Warming.AdventureWorks.BL.Repositories
{
    internal class Products : 
        EntityFrameworkRepository<AdventureWorks2014Entities>
    {
        private readonly GoupWare.AdventureWorks.Model.AdventureWorks2014Entities _context;
        private string _includeProperties;

        internal Products(AdventureWorks2014Entities context) : base(context)
        {
            _context = context;
            _includeProperties = null;
        }

        internal Products (AdventureWorks2014Entities context,
            string includeProperties) : base (context)
        {
            _context = context;
            _includeProperties = includeProperties;
        }

        /// <summary>
        /// Obtiene un listado de los productos cuyo color sea 
        /// similar al patrón establecido.
        /// </summary>
        /// <param name="colorPattern">patrón de consulta de 
        /// color.  Puede contener únicamente una parte del 
        /// nombre del color.</param>
        /// <returns>lista de productos que cumplen con la 
        /// condición.</returns>
        internal IQueryable<Product> ProductsByColor (string colorPattern)
        {
            IQueryable<Product> products = GetQueryable<Product>
                            (x => x.Color.Contains(colorPattern),
                            null, _includeProperties,null,null);
            return products;
        }
    }
}
