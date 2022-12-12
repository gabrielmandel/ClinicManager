namespace Stefanini_CRUD.Domain.Aggregate
{
    public sealed class City
    {
        public City()
        {
        }
        
        private City(City city)
        {
            this.Name = city.Name;
            this.UF = city.UF;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string UF { get; set; }
     

        public static City Create(City city)
        {
            if (string.IsNullOrEmpty(city.Name)) 
                throw new ArgumentException("Invalid " + nameof(city.Name));

            if (string.IsNullOrEmpty(city.UF))
                throw new ArgumentException("Invalid " + nameof(city.UF));

            return new City(city);
        }

        public void Update(City city)
        {
            if (!string.IsNullOrEmpty(city.Name)) 
                Name = city.Name;

            if (!string.IsNullOrEmpty(city.UF))
                UF = city.UF;
        }
    }
}
