using System.Collections.Generic;

namespace LoadTypesLesson
{
    public class Item : Entity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public ICollection<Cart> Carts { get; set; } = new List<Cart>();
    }
}
