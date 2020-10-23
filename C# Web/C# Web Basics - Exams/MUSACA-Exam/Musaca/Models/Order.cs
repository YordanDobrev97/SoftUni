using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Musaca.Models
{
    public class Order
    {
        public Order()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public Status Status { get; set; }

        [ForeignKey("Product")]
        public string ProductId { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        public User User { get; set; }
    }
}
