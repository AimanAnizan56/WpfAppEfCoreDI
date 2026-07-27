using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppEfCoreDI.Domain.Entities
{
    public class Product
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string ShortDescription { get; set; }
        public string Quantity { get; set; }
        public bool IsDeleted { get; set; }
    }
}
