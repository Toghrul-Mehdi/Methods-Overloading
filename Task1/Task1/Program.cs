//1.Min methodu yaradılır. Daxil olunan arrayın ən kiçik elementini tapır.
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array= { -2,11, 0, 3, 4, 5};
            Console.WriteLine(Min(array));
        }
        static int Min(int[] array) 
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++) 
            { 
                if(array[i]<min)
                {
                    min= array[i];
                }
            }
            return min;
        }
    }
}
