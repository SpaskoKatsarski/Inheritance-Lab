using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList rndList = new RandomList();
            rndList.Add("Spasko");
            rndList.Add("Krisi");
            rndList.Add("Toncho");
            rndList.Add("Vanko");
            Console.WriteLine(rndList.Count);
            Console.WriteLine(rndList.RandomString());
            Console.WriteLine(rndList.Count);
        }
    }
}
