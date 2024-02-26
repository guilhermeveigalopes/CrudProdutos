using System;
using System.Collections.Generic;

namespace CrudProdutos.Models
{
    public partial class Fornecedor
    {
        public Fornecedor()
        {
            Produtos = new HashSet<Produto>();
        }

        public int IdFornecedor { get; set; }
        public string? Nome { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
