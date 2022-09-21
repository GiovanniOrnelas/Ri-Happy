using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace SendOrder
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //criando uma lista para guardar os dados do excel
            List<Order> orderList = GetDataExcel.returnDateExcel();

            //como o método retorna os dados do excel, precisamos transformar esses dados em um json, então chamamos o método 'SerializeObject'
            var json = JsonConvert.SerializeObject(orderList);

            //criando o arquivo json            
            File.WriteAllText(@"C:\Users\giorn\Desktop\teste.json", json);

            //avisando que o arquivo foi criado
            Console.WriteLine("Já foi criado o arquivo .json");

            //lendo um arquivo json e jogando tudo dentro da variável 'readText'
            var readText = File.ReadAllText(@"C:\Users\giorn\Desktop\teste.json");

            //deserializando os dados da variável 'readText' que é um json para se tornar dados válidos para uma lista
            orderList = JsonConvert.DeserializeObject<List<Order>>(readText);

            //instância da classe repository
            repository r = new();

            //loop para pegar a quantidade de itens dentro da lista
            for (int i = 0; i <= orderList.Count; i++)
            {
                //enviando para o fluxo de rihappy os dados de um determinado índice da lista 'orderList'
                var sucsses = await r.SendAsyncOrder(orderList[i], i);

                //esperando 2 segundos para rodar novamente o loop
                Thread.Sleep(2000);
            }

            Console.WriteLine("Já enviei todos os retroativos!");

            Console.ReadKey();
        }
    }
}