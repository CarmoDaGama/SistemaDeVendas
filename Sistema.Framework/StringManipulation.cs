using System.Linq;

namespace Sistema.Framework
{
    public static class StringManipulation
    {
        private static string AlfabetoMaiusculo  = "ABCDEFGHIJKLMOPQRSTUVWXYZ";
        private static string AlfabetoMenusculo = "ABCDEFGHIJKLMOPQRSTUVWXYZ".ToLower();
        private static string Numeros = "1234567890";
        private static string CharsEpacials = "|\\!\"@#£$§%€&/{([)]=}?'«»+*¨´`~^-_:.,;<>";
        public static bool ContemNumero(string sequenciaString)
        {
            return sequenciaString.Where(s => Numeros.Contains("" + s)).FirstOrDefault() != '\0';
        }
        public static bool ContemCharsEpacials(string sequenciaString)
        {
            return sequenciaString.Where(s => CharsEpacials.Contains("" + s)).FirstOrDefault() != '\0';
        }
        public static bool IsMaiuscula(char letra)
        {
            return AlfabetoMaiusculo.Contains(letra);
        }
        public static bool IsMenuscula(char letra)
        {
            return AlfabetoMenusculo.Contains(letra);
        }
    }
}
