﻿namespace Store.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ImgURL { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
