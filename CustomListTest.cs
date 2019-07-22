using System;
namespace Application
{
    public class CustomListTest
    {
        public CustomListTest()
        {

			private T[] items = new T[1];
		    public T this[int i]
		{
			get { return items[i]; }
			protected set { items[i] = value; }

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
				count = value;

			}


		}
		private int capacity;

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
		//public string AddSinger(string count)
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
}
        }
    }
}
