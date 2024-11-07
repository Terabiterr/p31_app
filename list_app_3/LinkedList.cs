using System.Collections;

namespace list_app_3
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }
    public class LinkedList<T> : IEnumerable<T>
    {
        private Node<T> head;
        public int Count { get; private set; }
        public LinkedList()
        {
            head = null;
        }
        public void Add(T value)
        {
            var newNode = new Node<T>(value);
            Count++;
            if(head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        public T this[int index]
        {
            get
            {
                if(index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                Node<T> current = head;
                int currentIndex = 0;
                while (current != null)
                {
                    if(currentIndex == index)
                    {
                        return current.Value;
                    }
                    current = current.Next;
                    currentIndex++;
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if(index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                Node<T> current = head;
                int currentIndex = 0;
                while (current != null)
                {
                    if (currentIndex == index)
                    {
                        current.Value = value;
                        return;
                    }
                    current = current.Next;
                    currentIndex++;
                }
                throw new IndexOutOfRangeException();
            }
        }
        public void Print()
        {
            if(head == null)
            {
                Console.WriteLine("The lists is empty ...");
                return;
            }
            Node<T> current = head;
            while (current != null)
            {
                Console.WriteLine($"{current.Value}\t");
                current = current.Next;
            }
        }

        public void Remove(T value)
        {
            //Додати реалізацію метода
            //Hello
        }

        public bool Find(T value)
        {
            //Якщо елемент знайден, повернути true інакше false
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
