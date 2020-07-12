using System;
using System.Collections.Generic;
using System.Text;

namespace OlegTask
{
    public class PersonGenerator
    {
        public Person Generate(int id)
        {
            Person person = new Person(id, new SalaryGenerator().Generate(), new CompanyNameGenerator().Generate(),
                new NameGenerator().Generate());
            return person;
        }
    }
}
