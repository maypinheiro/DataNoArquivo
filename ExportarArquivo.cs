using System.IO;

namespace DataNoArquivo
{
 
        public class ExportarArquivo : IExportarDados
        {
            public void Exportar(string[] datas)
            {
                var contador = 0;

                foreach (var data in datas)
                {
                    contador++;
                    using (StreamWriter sw = File.AppendText($"Arquivo_{contador}.txt"))
                    {
                        sw.Write(data);
                    }
                }
            }
        }
    
}
