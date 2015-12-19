using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using AdventureWorks.Modelo;

namespace AdventureWorks.OrderDetail.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAdventureWorksOrderDetail
    {
        [OperationContract]
        List<SalesOrderDetail> ConsultarPorProductoID(int ID);

        [OperationContract]
        List<SalesOrderDetail> Todos();

        [OperationContract]
        List<SalesOrderDetail> ConsultaPorCantidad(int Cantidad);

        [OperationContract]
        List<SalesOrderDetail> ConsultaPorTotal(double Total);
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
