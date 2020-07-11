using System;
using System.Collections.Generic;
using System.Text;

namespace OlegTask
{
    public class MyTask
    {
        public void Run()
        {
            MyDB myDB = new MyDB();
            RequestGenerator requestGenerator = new RequestGenerator();
            Request request = requestGenerator.Generate();

        }
    }
}
