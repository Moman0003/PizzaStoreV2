namespace UML_2_PizzaStoreV2
{
    public class Pizza
    {
        private static int _nextNumber = 1;

        public int Number { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public List<string> Toppings { get; set; } = new List<string>();

        public Pizza()
        {
            Number = _nextNumber++;
        }

        public Pizza(string name, decimal price, List<string> toppings)
        {
            Number = _nextNumber++;
            Name = name;
            Price = price;
            Toppings = toppings;
        }

        public override string ToString()
        {
            return $"Nummer: {Number}, Navn: {Name}, Pris: {Price:C2}";
        }
    }
}
