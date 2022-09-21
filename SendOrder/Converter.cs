using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendOrder
{
    public class Converter
    {
        //para usar o método, devemos informar qual planilha vai ser acessada 'worksheet' e em qual linha iremos pegar os dados 'row'
        public static Order getDataExcel(ExcelWorksheet worksheet, int row)
        {
            //criando uma instância da classe 'Order'
            var entidade = new Order();

            //com as informações passadas pelo parâmetro do método, conseguimos pegar os dados do execel de acordo com cada coluna e linha, transformando os dados em string e jogando dentro da instância 'entidade'
            entidade.ORDERID = worksheet.Cells[row, Col: 1].Value?.ToString();
            entidade.ID_SEQUENCE = Convert.ToInt32(worksheet.Cells[row, Col: 2].Value?.ToString());
            entidade.NOME_COMPLETO = worksheet.Cells[row, Col: 3].Value?.ToString();
            entidade.CPF = worksheet.Cells[row, Col: 4].Value?.ToString();
            entidade.EMAIL = worksheet.Cells[row, Col: 5].Value?.ToString();
            entidade.PHONE = worksheet.Cells[row, Col: 6].Value?.ToString();
            entidade.STATUS = worksheet.Cells[row, Col: 7].Value?.ToString();
            entidade.ORIGIN = worksheet.Cells[row, Col: 8].Value?.ToString();
            entidade.AFFILIATEDID = worksheet.Cells[row, Col: 9].Value?.ToString();
            entidade.SELLERNAME = worksheet.Cells[row, Col: 10].Value?.ToString();
            entidade.HOSTNAME = worksheet.Cells[row, Col: 11].Value?.ToString();
            entidade.INVOICENUMBER = worksheet.Cells[row, Col: 13].Value?.ToString();
            entidade.VL_TOTAL = Convert.ToDouble(worksheet.Cells[row, Col: 15].Value?.ToString());
            entidade.COURIERNAME = worksheet.Cells[row, Col: 16].Value?.ToString();
            entidade.COURIERID = worksheet.Cells[row, Col: 18].Value?.ToString();
            entidade.TRACKINGNUMBER = worksheet.Cells[row, Col: 19].Value?.ToString();
            entidade.TRACKINGURL = worksheet.Cells[row, Col: 20].Value?.ToString();
            entidade.DATA_FATURAMENTO = worksheet.Cells[row, Col: 12].Value?.ToString().ToString();
            entidade.DATA_CRIACAO_PEDIDO = worksheet.Cells[row, Col: 14].Value?.ToString().ToString();
            entidade.SHIPPINGESTIMATEDATE = worksheet.Cells[row, Col: 17].Value?.ToString().ToString();

            //retornando todos os dados pegos do excel daquela linha específica
            return entidade;
        }
    }
}
