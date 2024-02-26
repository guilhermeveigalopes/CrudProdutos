using System;
using System.Collections.Generic;

namespace CrudProdutos.Models
{
    public partial class Categorium
    {
        public Categorium()
        {
            Produtos = new HashSet<Produto>();
        }

        public int IdCategoria { get; set; }
        public string? Categoria { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
