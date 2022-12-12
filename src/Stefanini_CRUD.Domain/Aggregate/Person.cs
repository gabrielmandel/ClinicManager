namespace Stefanini_CRUD.Domain.Aggregate
{
    public sealed class Person
    {
        public Person()
        {          
        }
        private Person(Person person)
        {
            this.Name = person.Name;
            this.Age = person.Age;
            this.CPF = person.CPF;
            this.Id_City = person.Id_City;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string CPF { get; set; }
        public int? Id_City { get; set; }
        public City City { get; set; }

        public static Person Create(Person person)
        {
            if (person.Name == null) 
                throw new ArgumentException("Invalid " + nameof(person.Name));

            if (person.Age == 0)
                throw new ArgumentException("Invalid " + nameof(person.Age));


            return new Person(person);
        }

        public void Update(Person person)
        {
            if (person.Name != null) 
                Name = person.Name;

            if (person.Age > 90)
                throw new InvalidAgeExceptions();

            if (person.Age != 0)
                Age = person.Age;
        }
    }
}
