using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OlegTask
{
    public class MyDB
    {
        private List<Person> objects;

        public MyDB()
        {
            this.objects = new List<Person>();
        }
        public Request GetAll()
        {
            int[] sequence = new int[objects.Count];
            for (int i = 0; i < sequence.Length; i++)
            {
                sequence[i] = objects[i].Id;
            }
            Request request = new Request(sequence);
            return request;
        }
        public void Add(Person person)
        {
            this.objects.Add(person);
        }
        public void Update(int id)
        {
            Person person = FindObject(id);
            person.Salary = new SalaryGenerator().Generate();
        }
        public void Remove(int id)
        {
            this.objects.Remove(FindObject(id));
        }
        private Person FindObject(int id)
        {
            return this.objects.Single(o => o.Id == id);
        }

    }
}
