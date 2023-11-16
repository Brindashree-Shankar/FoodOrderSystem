//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FoodOrderSystem.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int ProductId { get; set; }
        public int ResotoId { get; set; }
        public int Item { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public string OrderStatus { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime DeliverdDate { get; set; }
        public int Rating { get; set; }
        public decimal Discount { get; set; }
        public decimal DeliveryCharge { get; set; }
    
        public virtual Restorent Restorent { get; set; }
        public virtual User User { get; set; }
    }
}
