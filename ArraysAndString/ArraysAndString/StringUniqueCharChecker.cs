using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysAndString
{
    public class StringUniqueCharChecker
    {
        public bool IsEveryCharacterUniqueWithAddDataStruct(string stringToCheck)
        {
            var stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            if (stringToCheck.Length > 256 || string.IsNullOrWhiteSpace(stringToCheck))
                return false;

            var hashTable= new Dictionary<char,bool>();

            foreach (char t in stringToCheck)
            {
                if (hashTable.ContainsKey(t))
                {
                    Console.WriteLine("Time to run: " + stopWatch.Elapsed);
                    return false;
                }
                hashTable.Add(t,true);
            }
            Console.WriteLine("Time to run: "+stopWatch.Elapsed);
            stopWatch.Stop();
            return true;
        }

        public bool IsEveryCharacterUniqueBruteForce(string stringToCheck)
        {
            var stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();

            if (stringToCheck.Length > 256 || string.IsNullOrWhiteSpace(stringToCheck))
                return false;

            for (int i = 0; i < stringToCheck.Length; i++)
            {
                for (int j = i + 1; j < stringToCheck.Length; j++)
                {
                    if (stringToCheck[i] == stringToCheck[j])
                    {
                        Console.WriteLine("Time to run: " + stopWatch.Elapsed);
                        return false;
                    }
                }
            }
            //foreach (char t in stringToCheck)
            //{
            //    if (stringToCheck.IndexOf(t) == stringToCheck.LastIndexOf(t))
            //        return true;
            //    return false;
            //}
            Console.WriteLine("Time to run: " + stopWatch.Elapsed);
            stopWatch.Stop();

            return true;
        }

        public bool IsEveryCharacterUniqueWithSort(string stringToCheck)
        {
            var stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();

            if (stringToCheck.Length > 256 || string.IsNullOrWhiteSpace(stringToCheck))
                return false;
            var stringArray = stringToCheck.ToArray();
            Array.Sort(stringArray);
            for (var i = 0; i < stringArray.Length-1; i++)
            {
                if (stringArray[i] == stringArray[i + 1])
                {
                    Console.WriteLine("Time to run: " + stopWatch.Elapsed);
                    return false;
                }
            }
            Console.WriteLine("Time to run: " + stopWatch.Elapsed);
            stopWatch.Stop();

            return true;
        }
    }
}