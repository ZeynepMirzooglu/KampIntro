using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    public class MyList<T>
    {
         T[] items;

         public MyList()
         {
             items = new T[0];
         }
        public void Add(T item)
        {
            //Dizinin elemanlarını bir arttır.
            //Referans numarası eleman sayısı artınca kaybolmasın diye geçici bir diziye atayıp newlenince diğer referanslar silinmesin diye.

            T[] tempArray = items;
            items=new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                //Geçici diziden elemanları geri almak için yazılır.
                items[i] = tempArray[i];
            }
            //eklenmek istenen elemanı eklemek için:

            items[items.Length-1] = item;
        }
    }
}
