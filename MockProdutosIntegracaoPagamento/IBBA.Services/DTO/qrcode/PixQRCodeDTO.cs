using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBBA.Services.DTO.qrcode
{
    public class PixQRCodeDTO
    {
        public string pix_link { get; set; }
        public string emv { get; set; }
        public string imagem_base64 { get; set; }
    }
}
