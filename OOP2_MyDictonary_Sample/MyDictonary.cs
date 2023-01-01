using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_MyDictonary_Sample
{
    class MyDictonary<T,U>
    {
         T[] Key;       //city dizisi key ve value olarak ayrı ayrı tanımladım
         U[] Value;
               
        public MyDictonary()
        {
            //cities dizisini newleyerek constructor içinde oluşturdum.(başlangıçta içiboş)
            Key = new T[0];    
            Value = new U[0];
        }

        public void Add(T itemKey, U itemvalue)
        {
            //geçici dizi oluşturuyorum veriler kaybolmasın 
            //cityKey in referans adresini tempcityKey e atıyorum.
            T[] tempcityKey = Key;
            U[] tempcityValue = Value;

            Key = new T[Key.Length + 1];     //cities dizisinin elemen sayısını 1 artırdım
            Value = new U[Value.Length + 1];

            for (int i = 0; i < tempcityKey.Length; i++)
            {
                Key[i] = tempcityKey[i];    //tempcities de tuttugum elemanları cities diziisne geri alıyorum
                Value[i] = tempcityValue[i];
            }

            //Kullanıcıdan gelen parametreyi dizinin son elemanını olarak ekliyorum
            Key[Key.Length - 1] = itemKey;
            Value[Value.Length - 1] = itemvalue;
        }


        //eleman sayısını veren metot
        public int MyLength      
        {
            get { return Key.Length; }
        }

        //elemanları Listeli ekrana yazdıran metot
        public void List()
        {
            foreach (var ckey in Key)
            {
                Console.WriteLine($"Key: {ckey}");
            }
            foreach (var cvalue in Value)
            {
                Console.WriteLine($"Value: {cvalue}");
            }
        }


    }
}
