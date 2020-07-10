using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OlegTask
{
    public class RequestGenerator
    {
        public Request Generate(MyDB myDB)
        {
            Random random = new Random();
            Request request = myDB.GetAll();
            string[] ids = request.GetRequest().Split(',');
            int[] result = new int[random.Next(1, 10)];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = random.Next(1, 10);
            }

            return new Request(result.Distinct().ToArray());
        }
    }
}
