using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>  
    {
        public string RandomString()
        {
            Random rnd = new Random();
            int index = rnd.Next(0, base.Count);

            string removedStr = base[index];
            base.RemoveAt(index);
            return removedStr;
        }
    }
}
