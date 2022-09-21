using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SendOrder
{
    public class repository
    {
        //chama uma classe HTTP para fazermos requisições HTTP
        static readonly HttpClient client = new HttpClient();

        public async Task<string> SendAsyncOrder(Order order, int index)
        {
            //variável que irá guardar a posição da lista
            var status = "index: " + index;
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage()
            {
                //definindo que tipo de método de requisição iremos usar
                Method = HttpMethod.Post,
                //definindo qual será a url que irá receber esses dados que estamos enviando
                RequestUri = new Uri("https://gasggaghahshawe.requestcatcher.com/"),
                //pegando os dados da lista, deixando-os em uma formato JSON com o 'SerializeObject'
                Content = new StringContent(JsonConvert.SerializeObject(order), Encoding.UTF8, "application/json")
            };
            //aqui estamos enviando toda a requisição dentro do corpo da instância 'httpRequestMessage'
            var response = await client.SendAsync(httpRequestMessage);
            //var responseString = await response.Content.ReadAsStringAsync();
            //se o status do envio for diferente de true, ele irá printar que deu falha em algum index da lista
            if (!response.IsSuccessStatusCode)
                status = "failed index: " + index;

            return status;
        }
    }
}