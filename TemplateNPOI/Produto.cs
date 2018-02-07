using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesteExcelNPOI
{
    public class Produto
    {
        public string CodigoBarras { get; set; }
        public string NomeProduto { get; set; }
        public string Categoria { get; set; }
        public DateTime DataCadastro { get; set; }
        public int QtdEstoque { get; set; }
        public double PrecoVenda { get; set; }
    }
}