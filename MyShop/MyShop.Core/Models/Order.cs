using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Order : BaseEntity
    {
        public Order()
        {
            this.OrderItems = new List<OrderItem>();
        }

        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string OrderStatus { get; set; }
        public DeliveryType Delivery { get; set; } //Added Enum Property
        public string DeliveryMethod { get; set; }
        public decimal BasketTotal { get; set; }
        public decimal FinalTotal { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public enum DeliveryType
        {
            Courier,
            Collect
        }

        public decimal CalcOrderFinalTotal()
        {
            decimal finaltotal = BasketTotal;

            if (BasketTotal >= 350)
            {
                //Free
            }
            else  // No Free Delivery
            {
                if (Delivery == DeliveryType.Courier)
                {
                    if (DeliveryMethod == "Standard Delivery")
                    {
                        finaltotal += 60; 
                    }
                    else
                    if (DeliveryMethod == "Express Delivery")
                    {
                        finaltotal += 95;
                    }
                }
                else

                if (Delivery == DeliveryType.Collect)
                {
                    if (DeliveryMethod == "Normal Collection")
                    {
                        finaltotal += 25;
                    }
                    else
                    if (DeliveryMethod == "Delayed Collection")
                    {
                        finaltotal += 50;
                    }
                }
            }

            return finaltotal;
        }
    }
}