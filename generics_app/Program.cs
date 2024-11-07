namespace generics_app
{
    public class Box<T, T2>
    {
        public T Value { get; private set; }
        public T2 Value2 { get; private set; }
        public object Value3 { get; private set; }
        public Box(T value, T2 value2, object value3)
        {
            Value = value;
            Value2 = value2;
            Value3 = value3;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Box<int, string> box = new Box<int, string>(5, "Hi", 2.5);
            Console.WriteLine(box.Value);
            Console.WriteLine(box.Value2);
            Console.WriteLine(box.Value3);
        }
    }
}
