using System;
using System.Collections.Generic;
using System.Text;

namespace DataNoArquivo
{

        public class ExportarConsole : IExportarDados
        {
            public void Exportar(string[] datas)
            {
                foreach (var data in datas)
                {
                    Console.WriteLine(data);
                }
            }
        }
    
}
