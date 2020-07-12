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
            Request request = new Request();
            for (int i = 0; i < 3; i++)
            {
                request = requestGenerator.Generate();
                Console.WriteLine("Request was : " + request.GetRequest());
                myDB.ProcessRequest(request);
                Console.WriteLine("Result is : " + myDB.GetAll().GetRequest());
                Console.WriteLine();
            }
        }
    }
}
