namespace alqoritm_suali_18;
class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        int[] numbers = { 1, 2, 3, 4, -5, 6, 7, -8, 9 };
        for (int i = 1; i < numbers.Length; i++)
        {

            if ((numbers[i] > 0 && numbers[i - 1] < 0) || (numbers[i] < 0 && numbers[i - 1] > 0)) 

                    count++;

            
        }
        Console.Write(count);



    }
}

