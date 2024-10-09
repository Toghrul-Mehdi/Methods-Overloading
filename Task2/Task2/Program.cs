//2.İstənilən verilən cümlədə sözlərin baş hərflərini
//ekrana yazdıran method yazın məs .("Hello World --> "H" "W" )
using System.Reflection;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string metn = "      Hello     sadawd     World";
            Bash(metn);
        }
        static string Bash(string metn)
        {
            string result = "";
            

            for (int i = 0; i < metn.Length; i++)
            {
                if (i == 0 && metn[i + 1] != ' ')
                {
                    Console.Write(metn[i]+" ");
                }
                if (i > 0 && metn[i] == ' ' && metn[i + 1] !=' ')
                {
                    Console.Write(metn[i+1]+" ");  
                }
            }
            return result;
        }
    }
}
