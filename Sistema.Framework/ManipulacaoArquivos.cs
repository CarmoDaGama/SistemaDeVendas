using System.IO;

namespace Sistema.Framework
{
    public class ManipulacaoArquivos
    {
        public static void CriarArquivo(string caminhoArquivo, string dados)
        {
            File.Delete(caminhoArquivo);
            StreamWriter writeH;
            writeH = File.CreateText(caminhoArquivo);
            writeH.Write(dados);
            writeH.Close();
        }
    }
}
