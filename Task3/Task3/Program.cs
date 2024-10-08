//3.Parametr olaraq 1 string dəyər qəbul edən və
//həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod.
//Misal olaraq , name = "Yusif Osmanov" deyə bir variable-mız varsa onu
//yaratdigimiz metoda göndərdikdə variable-daki dəyər "YusifOsmanov" olmalıdır.
namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Yusif Osmanov";
            Hershey_bitishik(name);

        }
        static void Hershey_bitishik(string name) 
        {
            for (int i = 0; i < name.Length; i++) 
            {
                int ascii_movqe=(int)name[i];
                if (ascii_movqe == 32)
                {
                    continue;
                }
                Console.Write(name[i]);
            }
        }
    }
}
