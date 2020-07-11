using System;
using System.Collections.Generic;
using System.Text;

namespace OlegTask
{
    public class NameGenerator
    {
        public string Generate()
        {
            string[] names = new string[10] { "Bob", "Alice", "Aiden", "Alex", "Tom", "Erik", "Jason", "Frank", "Madison", "Rachel" };
            Random random = new Random();
            return names[random.Next(0, 10)];
        }
    }
}
