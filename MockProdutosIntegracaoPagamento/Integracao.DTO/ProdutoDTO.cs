using Integracao.DTO.Enum;
using System;

namespace Integracao.DTO
{
    public class ProdutoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public CategoriaProduto Categoria { get; set; }
    }
}
