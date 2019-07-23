using System;

namespace CustomListProject
{
    //IEnumerable
    public class CustomListTest<T>
    {


        private T[] list = new T[1];

        public T this[int i]
        {
            get { return list[i]; }
            protected set { list[i] = value; }
        }
        
        public void Add(T list)
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine();
            }

        }
        public static Swap<T>(ref T item, ref T item2);
        {
            T temp;
            temp = item;
            item = item2;
            item2 = temp;
        }
        
        private int count;
        public int Count
        {
            get
            {
            return count;
            }
            set
            {
            if (value => 0)
            {
                count = value;
            }
            else if (value >= 12)
            {
                count = value;
            }

            }
        }


        
        private int capacity;
        public int Add(int capacity);
        if ();
        public int Capacity
        {
            get
            {
                return Capacity;
            }
            set
            {
                capacity = value;

            }
        }
        private int remove;

        public int Remove
        {
            get
            {
                return Remove;
            }
            set
            {
                remove = value;

            }

        }
}

