﻿using System;
using System.Collections.Generic;

namespace CustomListProject
{
    public class CustomListTest<T> : IEnumerable;
    {
        private List<string> singerList;

        public CustomListTest()
        {
            singerList = new List<string>() { "MercyMe", "Chris Tomlin", "King & Country", };
        }

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
        public string AddSinger(string count)

        
       
        
        
        


    }
}
