using System.Collections.Generic;

namespace list_app_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            list[4] = 15;

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
