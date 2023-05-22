using System.Text.RegularExpressions;

namespace Whapify.api.Utilitarios.Herramientas
{
    public interface IValidadores
    {
        public bool IsNumeric(string input);
    }
    public class Validadores:IValidadores
    {
        public bool IsNumeric(string input)
        {
            Regex regex = new Regex("^[0-9]+$");

            return regex.IsMatch(input);
        }
    }
}
