using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace GenericOlegTask
{
    public class Database<T> where T : class, new()
    {
        private List<T> objects;

        public Database()
        {
            this.objects = new List<T>();
        }
        public void Serialize()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            var json = JsonSerializer.Serialize(this.objects, options);
            Console.WriteLine(json);
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
