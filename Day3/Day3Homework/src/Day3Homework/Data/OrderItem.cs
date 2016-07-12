namespace Day3Homework.Data
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Name { get; set; }

        public virtual Order Order { get; set; }
    }
}
