namespace AnagramOfString
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            foreach (string str in strs)
            {
                char[] arr = str.ToCharArray();
                Array.Sort(arr);
                string key = new string(arr);
                if (!dict.ContainsKey(key))
                {
                    dict[key] = new List<string>();
                }
                dict[key].Add(str);
            }
            IList<IList<string>> result = new List<IList<string>>();
            foreach (KeyValuePair<string, List<string>> entry in dict)
            {
                result.Add(entry.Value);
            }
            return result;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
            IList<IList<string>> result = program.GroupAnagrams(strs);
            foreach (IList<string> group in result)
            {
                foreach (string str in group)
                {
                    Console.Write(str + " ");
                }
                Console.WriteLine();
            }
        }
    }
}