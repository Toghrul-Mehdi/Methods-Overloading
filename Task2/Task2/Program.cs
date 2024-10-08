//2.İstənilən verilən cümlədə sözlərin baş hərflərini ekrana yazdıran method yazın məs .("Hello World --> "H" "W" )
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string metn = "Hello World";
            Bash_Herf(metn);
        }

        static void Bash_Herf(string metn)
        {
            for (int i = 0; i < metn.Length; i++) 
            {
                int ascii_movqe=(int)metn[i];
                if (ascii_movqe <=90 && ascii_movqe >= 65)
                {
                    Console.Write(metn[i] + " ");
                }
            }
        }
    }
}
