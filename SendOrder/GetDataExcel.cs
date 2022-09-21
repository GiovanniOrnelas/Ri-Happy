using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendOrder
{
    public class GetDataExcel
    {
        public static List<Order> returnDateExcel()
        {
            //criando uma lista de objetos (lista de objetos são listas que recebe números e letras
            var response = new List<Order>();

            //verificando se o arquivo existe
            FileInfo existingFile = new FileInfo(fileName: "C:\\Users\\giorn\\Desktop\\teste.xlsx");

            //usando um tipo de licença para saber se temos o produto pago ou não (usamos isso pois a classe exige)
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            //usando a classe 'ExcelPackage' para acessar a planilha
            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                //dentro de uma planilha, podem existir várias outras planilhas, então o que estamos fazendo na linha 26 é basicamente falando para ele pegar a planilha da posição 0, que seria a primeira planilha de todas
                ExcelWorksheet worksheet = package.Workbook.Worksheets[PositionID: 0];

                //pegando a quantidade de colunas do excel
                /*int colCount = worksheet.Dimension.End.Column;*/

                //pegando a quantidade de linhas do excel
                int rowCount = worksheet.Dimension.End.Row;

                //criando loop para rodar todas as linhas do excel
                for (int row = 2; row <= rowCount; row++)
                {
                    //pegando a referência da planilha com a variável 'worksheet' e dando para o método em qual linha ele deve pegar os dados de acordo com cada loop e guardando os valores dentro da variável 'entidade'
                    var entidade = Converter.getDataExcel(worksheet, row);
                    //quando os dados ficarem na variável entidade, adicionamos os dados dentro da lista 'response'
                    response.Add(entidade);
                }
                //por fim, retornarmos esses dados
                return response;
            }
        }
    }
}
