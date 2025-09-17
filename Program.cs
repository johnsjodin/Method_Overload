namespace Method_Overload
{
    internal class Program
    {
        /*      Varför är detta överlagring?
         * Det är överlagring för att det finns flera metoder med samma namn (FormatName)
         * som tar emot olika typer eller antal argument.
         * 
         *      Hur gör detta koden lättare att läsa & återanvända?
         * I och med att det är samma namn på metoderna så behöver man inte skriva olika
         * metodnamn på andra ställen i koden för att formatera namnen på olika sätt, och
         * om man behöver formattera namnet på ett nytt sätt så är det bara att lägga till
         * en metod med samma namn och man behöver inte ändra något annat i koden.
        */

        static void Main(string[] args)
        {
            Console.WriteLine(FormatName("Anna", "Svensson"));
            Console.WriteLine(FormatName("Anna", "Maria", "Svensson"));
            Console.WriteLine(FormatName("Anna", "Svensson", true));
        }
        static string FormatName(string first, string last)
        {
            return $"{first} {last}";
        }

        static string FormatName(string first, string middle, string last)
        {
            return $"{first} {middle} {last}";
        }

        static string FormatName(string first, string last, bool uppercase)
        {
            var full = $"{first} {last}";
            return uppercase ? full.ToUpper() : full;
        }
    }
}
