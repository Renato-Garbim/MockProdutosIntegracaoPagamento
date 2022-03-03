using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBBA.Services.DTO.pagamento
{
    public class NovoPagamentoDTO
    {
        public bool Ativa { get; set; }
        public string Txid { get; set; }
        public string revisao { get; set; }
        public string location { get; set; }        
    }
}
