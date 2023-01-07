﻿namespace TPharmacy.Shared.Domain
{
    public class OrderItem : BaseDomainModel
    {
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public int OrderItemQtny { get; set; }

    }
}
