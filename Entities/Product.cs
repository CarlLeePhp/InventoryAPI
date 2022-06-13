namespace Inventory.Entities
{
    public class Product
    {
        // Product (Id, Name, Unit, IsWatching, WarnLevel, IsActive, Stock)
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Unit { get; set; } = "";
        public bool IsWatching { get; set; }
        public int WarnLevel { get; set; }
        public bool IsActive { get; set; }
        public int Stock { get; set; } = 0;
    }
}
