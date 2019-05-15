using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestandoAPICorreios.Model
{
    class EnderecoCompleto
    {
        private string cep;
        private string logradoudo;
        private string complemento;
        private string bairro;
        private string localidade;
        private string uf;
        private int indicePopulacional;

        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public int IndicePopulacional { get; set; }
    }
}
