namespace WildFarm.Models
{
    public abstract class Mammal : Animal
    {
        public Mammal(string name, string type, double weight, string livigRegion) 
            : base(name, type, weight)
        {
            this.LivingRegion = livigRegion;
        }

        public string LivingRegion { get; set; }

        public override string ToString()
        {
            return $"{this.Type}[{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
