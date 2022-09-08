using System;
using System.Collections.Generic;

namespace DataNoArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            var formatarDatas = new FormatarDatas(@"C:\Users\017586631\source\repos\DataNoArquivo\Data.txt");
            formatarDatas.Converter();

            var listaDeExportacao = new List<IExportarDados>();
            listaDeExportacao.Add(new ExportarConsole());

            foreach (var exportacao in listaDeExportacao)
            {
                formatarDatas.ExportarDados(exportacao);
            }
        }
    }
}
