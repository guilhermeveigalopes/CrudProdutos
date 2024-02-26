using System;
using System.Collections.Generic;

namespace CrudProdutos.Models
{
    public partial class Produto
    {
        public int Idproduto { get; set; }
        public string? Descricao { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdFornecedor { get; set; }

        public virtual Categorium? IdCategoriaNavigation { get; set; }
        public virtual Fornecedor? IdFornecedorNavigation { get; set; }
    }
}
