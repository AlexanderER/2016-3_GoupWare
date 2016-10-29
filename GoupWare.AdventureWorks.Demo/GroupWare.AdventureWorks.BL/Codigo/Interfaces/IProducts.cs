using GoupWare.AdventureWorks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Entity.Framework.Warming.AdventureWorks.BL
{
    /// <summary>
    /// Métodos disponibles para consultar el repositorio de Productos
    /// </summary>
    [ServiceContract]
    public interface IProducts
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
        [OperationContract]
        IQueryable<Product> ListProductsByColor(string colorPattern);

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
