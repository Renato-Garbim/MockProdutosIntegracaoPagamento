using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integracao.DTO
{
    public class DadosPessoaisDTO
    {
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [DisplayName("CEP")]
        public string CEP { get; set; }

        [DisplayName("Telefone")]
        public string Telefone { get; set; }
        
        [DisplayName("Email")]
        public string Email { get; set; }
    }
}
