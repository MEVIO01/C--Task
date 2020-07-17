using System;
using System.Collections.Generic;
using System.Text;

namespace GenericOlegTask
{
    public class Database<T> where T : class, new()
    {
        private List<T> objects;

        public Database()
        {
            this.objects = new List<T>();
        }
        public void DisplayAll()
        {
            foreach (var ob in this.objects)
            {
                Console.WriteLine(ob);
            }
        }
        public void Add(T ob)
        {
            this.objects.Add(ob);
        }
    }
}
