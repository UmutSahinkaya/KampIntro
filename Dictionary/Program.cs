using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------My DİCTİONARY-------");
            MyDictionary<int, string> myDictionaryList = new MyDictionary<int, String>();
            myDictionaryList.Add(1993, "Umut Şahinkaya");
            myDictionaryList.Add(1965, "Nihan Şahin");
            myDictionaryList.Add(1995, "Reyhan Kırık");
            myDictionaryList.ShowKeysValues();
            Console.WriteLine(myDictionaryList.Count); 

        }







        class MyDictionary<K, V> 
        {
            K[] keys;
            V[] valuess;
            public MyDictionary()
            {
                keys = new K[0];
                valuess = new V[0];
            }
            public void Add(K customerId, V customerName)
            {
                K[] tempKeys = keys;
                V[] tempValuess = valuess;

                keys = new K[keys.Length + 1];
                valuess = new V[valuess.Length + 1];

                for (int i = 0; i <tempKeys.Length; i++)
                {
                    keys[i] = tempKeys[i];
                }
                for (int i = 0; i < tempValuess.Length; i++)
                {
                    valuess[i] = tempValuess[i];
                }
                keys[keys.Length - 1] = customerId;
                valuess[valuess.Length - 1] = customerName;
            }

                public int Count
                {
                get { return keys.Length; }
                }
                public void ShowKeysValues()
               {
                for (int i = 0; i < keys.Length; i++)
                {
                    Console.WriteLine("Key:{0}  ------ Values:{1}", keys[i], valuess[i]);
                }
               }

        }

    }
}
