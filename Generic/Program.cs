namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
             ARR<int> A = new ARR<int>();
            A.add(1);
            A.add(2);
            A.add(3);
            A.add(4);
            A.add(5);
            A.Remove(1);
            A.display();

        }
    }


    class ARR<T>
    {
        private T[] items;

        public void add(T item)
        {
            if (items is null)
            {
                items = new T[] { item };

            }
            else
            {
                int length = items.Length;
                T[] temp = new T[length + 1];
                for(int i = 0; i < length; i++)
                {
                    temp[i] = items[i];
                }
                 temp[length - 1] = item;
                 items = temp;
            } 
        }
         
        public void Remove(int index)
        {
            T[] temp = new T[items.Length];
            int pos = 0;
            for(int i = 0; i <items.Length;i++)
            {
                if(i == index)
                {
                    continue;
                }
                temp[pos++] = items[i];
            }
        }

        public bool IsEmpty => items.Length == null;


        public int count() => items.Length;

        public void display()
        {
            Console.Write("[");
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write($"{items[i]},");
            }
            Console.WriteLine("]");
        }







    }
}
