using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TK, TV>
    {
        TK[] key;
        TV[] value;

        public MyDictionary()
        {
            key = new TK[0];
            value = new TV[0];
        }

        public void Add(TK tK, TV tV)
        {
            TK[] tempArrayKey = key;
            key = new TK[key.Length+1]; 
            TV[] tempArrayValue = value;
            value = new TV[value.Length+1];

            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                key[i]=tempArrayKey[i];
                value[i] = tempArrayValue[i];
            }

            key[key.Length-1]= tK;
            value[value.Length-1]= tV;



        }
        public void Write()
        {
            for (int i = 0; i < key.Length; i++)
            {
                Console.WriteLine(key[i]+ " " + value[i]);
            }
        }


        
    }


}
