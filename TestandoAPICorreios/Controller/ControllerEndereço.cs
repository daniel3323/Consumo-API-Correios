using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TestandoAPICorreios.Model;

namespace TestandoAPICorreios.Controller
{
    class ControllerEndereço
    {
        private EnderecoCompleto enderecoCompleto = new EnderecoCompleto();

        private string URL = "https://viacep.com.br/ws/";
        public EnderecoCompleto GetEndereçoCompleto(string cep)
        {
            using (var client = new HttpClient())
            {
                //Cabeçalho
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Request
                var response = client.GetAsync(string.Format(URL + cep + "/json")).Result;
                string responseString = response.Content.ReadAsStringAsync().Result;

                //Deserealizando conteúdo
                dynamic jsonDeserialized = JsonConvert.DeserializeObject(responseString);

                //setando conteúdo no objeto "Heroi"
                enderecoCompleto.Logradouro = jsonDeserialized.logradouro;
                enderecoCompleto.Complemento = jsonDeserialized.complemento;
                enderecoCompleto.Bairro = jsonDeserialized.bairro;
                enderecoCompleto.Localidade = jsonDeserialized.localidade;
                enderecoCompleto.UF = jsonDeserialized.uf;
                enderecoCompleto.IndicePopulacional = jsonDeserialized.ibge;

                return enderecoCompleto;
            }
        }

        public string GetJsonEndereco(string cep)
        {
            using (var client = new HttpClient())
            {
                string output = "";
                var content = new StringContent(output, Encoding.UTF8, "application/json");
                var response = client.GetAsync(string.Format(URL + cep + "/json")).Result;
                var responseContent = response.Content;
                string responseString = responseContent.ReadAsStringAsync().Result;

                return responseString;
            }
        }
    }
}
