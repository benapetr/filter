using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            while ((s = Console.ReadLine()) != null)
            {
                if (s.StartsWith("tools-webserver") && s.Contains("HTTP/"))
                {
                    if (s.Contains("+0000]"))
                    {
                        int position = 0;
                        position = s.IndexOf("+0000]") + 8;
                        int position_of_first = s.IndexOf("/", position);
                        int position_of_next = s.IndexOf("/", position_of_first + 1);
                        s = s.Substring(0, position_of_next) + "HTTP" + s.Substring(s.LastIndexOf("/"));
                        Console.WriteLine(s);
                    }
                }
            }
        }
    }
}
