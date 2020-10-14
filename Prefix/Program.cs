using System;
using System.Collections.Generic;
using System.Linq;

namespace Prefix
{
 


    public class Prefix
    {
        public static IEnumerable<string> AllPrefixes(int prefixLength, IEnumerable<string> words)
        {
            try
            {
                List<string> maList = new List<string>();


                foreach (var item in words)
                {
                    if (item.Length>prefixLength && !maList.Contains(item.Substring(0, prefixLength)))
                    {
                        //Console.WriteLine("TEST : "+ item);
                        //Console.WriteLine("TEST substring : "+ item.Substring(0, prefixLength));
                        //Console.WriteLine("___________________________");
                        maList.Add(item.Substring(0, prefixLength));
                    }
                }
                return maList;
            }
            catch (Exception e)
            {

                throw new InvalidOperationException("Waiting to be implemented. "+e.ToString());
                
            }
        
        }

        public static void Main(string[] args)
        {
            foreach (var p in AllPrefixes(  3, 
                                            new string[] { "flow", "flowers", "flew", "flag", "fm" }
                                         ))
            {
                Console.WriteLine(p);
                Console.WriteLine();
            }


        }
    }
}
