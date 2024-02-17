using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
     class MyList<T>
    {
        T[] items;
        //constructor 

        public MyList()// newlersek otomatik çalışır.
        {
            items = new T[0];
            
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++) 
            {
                items[i] = tempArray[i];

            }
            items[items.Length-1] = item; 
            
        }
    }
}
