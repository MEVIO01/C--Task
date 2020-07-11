using System;
using System.Collections.Generic;
using System.Text;

namespace OlegTask
{
    public class SalaryGenerator
    {
        public double Generate()
        {
            Random random = new Random();
            double salary = random.Next(0, 10000);
            salary += random.NextDouble();
            return salary;
        }
    }
}
