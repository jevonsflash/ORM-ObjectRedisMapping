using System;

namespace ObjectRedisMappingDemo.Model
{
    using System.Collections.Generic;
    using Blueve.ObjectRedisMapping;

    public class Person
    {
        [EntityKey]
        public string Name { get; set; }

        public short Age { get; set; }

        public IList<Person> Fellows { get; set; }
        
        public DateTime GoToSchool { get; set; }
    }
}
