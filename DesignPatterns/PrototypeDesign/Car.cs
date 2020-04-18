namespace DesignPatterns.PrototypeDesign
{
    public class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }

        public int Year { get; set; }

        /// <summary>
        /// Clona esta Classe usando MemberwiseClone
        /// </summary>
        public Car ShallowCopy()
        {
            return (Car) this.MemberwiseClone();
        }

        /// <summary>
        /// Clona esta classe usanod método DeepClone
        /// </summary>
        /// <returns></returns>
        public Car DeepCopy()
        {
            return new Car
            {
                Brand = this.Brand,
                Model = this.Model,
                Year = this.Year
            };
        }
    }
}