using IBBA.Services.DTO;
using IBBA.Services.DTO.pagamento;
using IBBA.Services.DTO.qrcode;
using IBBA.Services.DTO.token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBBA.Services.Interfaces
{
    public interface IPixApiService
    {
        token GerarToken();
        NovoPagamentoDTO GerarPedido(string token, DadosEnvioPixDTO model);
        PixQRCodeDTO ObterQRCodePixPor(string txid, string token);
    }
}
