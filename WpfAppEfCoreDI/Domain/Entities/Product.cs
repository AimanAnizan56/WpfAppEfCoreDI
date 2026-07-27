using System;
using System.Collections.Generic;
using System.Text;
using WpfAppEfCoreDI.Domain.Common;

namespace WpfAppEfCoreDI.Domain.Entities
{
    public class Product: ITrackable
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string ShortDescription { get; set; }
        public string Quantity { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
