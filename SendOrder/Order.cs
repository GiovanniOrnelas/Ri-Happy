using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendOrder
{
    public class Order
    {
        //criando as variáveis
        public string ORDERID { get; set; }
        public int ID_SEQUENCE { get; set; }
        public string NOME_COMPLETO { get; set; }
        public string CPF { get; set; }
        public string EMAIL { get; set; }
        public string PHONE { get; set; }
        public string STATUS { get; set; }
        public string ORIGIN { get; set; }
        public string AFFILIATEDID { get; set; }
        public string SELLERNAME { get; set; }
        public string HOSTNAME { get; set; }
        public string DATA_FATURAMENTO { get; set; }
        public string INVOICENUMBER { get; set; }
        public string DATA_CRIACAO_PEDIDO { get; set; }
        public double VL_TOTAL { get; set; }
        public string COURIERNAME { get; set; }
        public string SHIPPINGESTIMATEDATE { get; set; }
        public string COURIERID { get; set; }
        public string TRACKINGNUMBER { get; set; }
        public string TRACKINGURL { get; set; }
    }
}