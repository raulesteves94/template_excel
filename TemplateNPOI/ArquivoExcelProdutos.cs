using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace TesteExcelNPOI
{
    public class ArquivoExcelProdutos
    {
        private List<Produto> _produtos;
        private string _nomeArquivo;
        private HSSFWorkbook _workbookCatalogo;

        public ArquivoExcelProdutos(List<Produto> produtos)
        {
            this._produtos = produtos;
        }

        public void GerarArquivo(string nomeArquivo)
        {
            this._nomeArquivo = nomeArquivo;

            FileStream file = new FileStream(ConfigurationManager
                .AppSettings["TemplateArquivoExcelProdutos"],
                    FileMode.Open, FileAccess.Read);
            _workbookCatalogo = new HSSFWorkbook(file);

            PreencherInformacoesProdutos();
            FinalizarGravacaoArquivo();
        }

        private void PreencherInformacoesProdutos()
        {
            ISheet sheetCatalogo =
                _workbookCatalogo.GetSheet("Catálogo");

            int numeroProximaLinha = 3;
            foreach (Produto produto in _produtos)
            {
                sheetCatalogo.GetCell(numeroProximaLinha, 1)
                    .SetCellValue(produto.CodigoBarras);
                sheetCatalogo.GetCell(numeroProximaLinha, 2)
                    .SetCellValue(produto.NomeProduto);
                sheetCatalogo.GetCell(numeroProximaLinha, 3)
                    .SetCellValue(produto.Categoria);
                sheetCatalogo.GetCell(numeroProximaLinha, 4)
                    .SetCellValue(produto.DataCadastro);
                sheetCatalogo.GetCell(numeroProximaLinha, 5)
                    .SetCellValue(produto.QtdEstoque);
                sheetCatalogo.GetCell(numeroProximaLinha, 6)
                    .SetCellValue(produto.PrecoVenda);
                numeroProximaLinha++;
            }
        }

        public void FinalizarGravacaoArquivo()
        {
            using (FileStream file = new FileStream(
                _nomeArquivo, FileMode.Create))
            {
                _workbookCatalogo.Write(file);
                file.Close();
            }
        }
    }
}