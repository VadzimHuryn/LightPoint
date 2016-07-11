namespace CartDBApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderItem")]
    public partial class OrderItem
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        public virtual Order Order { get; set; }
    }
}
