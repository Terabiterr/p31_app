namespace generics_app_2
{
    public class Program
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a; 
            a = b; 
            b = temp;
        }
        static void Main(string[] args)
        {
            ////Boxing
            //int number = 123;
            //object obj = number;
            //Console.WriteLine(obj);
            ////Unboxing
            //int unboxedNumber = (int)obj;
            //Console.WriteLine(unboxedNumber);
            int a = 10, b = 20;
            Swap<int>(ref a, ref b);
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
        }
    }
}
