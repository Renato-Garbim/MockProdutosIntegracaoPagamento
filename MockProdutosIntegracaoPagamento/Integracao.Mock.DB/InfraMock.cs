using Integracao.DTO;
using Integracao.Mock.DB.Interface;
using System;
using System.Collections.Generic;

namespace Integracao.Mock.DB
{
    public class InfraMock : IInfraMock
    {
        public IEnumerable<ProdutoDTO> ListaProduto { get; set; }

        public InfraMock()
        {
            ListaProduto = PopularListaProduto();
        }

        private IEnumerable<ProdutoDTO> PopularListaProduto(){

            var list = new List<ProdutoDTO>();

            list.Add(new ProdutoDTO() { Id = 1, Nome = "", Descricao = "", Categoria = DTO.Enum.CategoriaProduto.starter,  Preco = 54 });
            list.Add(new ProdutoDTO() { Id = 2, Nome = "", Descricao = "", Categoria = DTO.Enum.CategoriaProduto.advanced, Preco = 78 });
            list.Add(new ProdutoDTO() { Id = 3, Nome = "", Descricao = "", Categoria = DTO.Enum.CategoriaProduto.premium, Preco = 120 });

            return list;
        }




    }
}
