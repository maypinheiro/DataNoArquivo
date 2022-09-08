using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace DataNoArquivo
{
    class FormatarDatas
    {
        private readonly string _caminhoArquivo;
        private string[] _datas;

        public FormatarDatas(string caminhoArquivo)
        {
            _caminhoArquivo = caminhoArquivo;
        }

        private DateTime LerArquivo()
        {
            return DateTime.Parse(File.ReadAllLines(_caminhoArquivo)[0]);
        }

        private string[] ConverterDataEmDiferentesFormatos(DateTime data)
        {
            return new string[]
            {
                data.ToString("MM/dd/yy"),
                data.ToString("yy/MM/dd"),
                data.ToString("dd-MM-yy")
            };
        }

        public void Converter()
        {
            var data = LerArquivo();
            _datas = ConverterDataEmDiferentesFormatos(data);
        }

        public void ExportarDados(IExportarDados exportarDados)
        {
            exportarDados.Exportar(_datas);
        }
    }
}
