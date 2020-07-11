using System;
using System.Collections.Generic;
using System.Text;

namespace OlegTask
{
    public class CompanyNameGenerator
    {
        public string Generate()
        {
            string[] names = new string[5] { "ASoftWare", "Enex", "BibiSoft", "Helex", "RSoft"};
            Random random = new Random();
            return names[random.Next(0, 5)];
        }
    }
}
