using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBBA.Services.DTO
{
    public class DadosEnvioPixDTO
    {
        public string Chave { get; set; }
        public CalendarioDTO Calendario { get; set; }
        public DevedorDTO Devedor { get; set; }
        public ValorDTO Valor { get; set; }


    }
}
