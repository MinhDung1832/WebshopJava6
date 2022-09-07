using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FPT_POLY_CHSARP5.Data.EF.Entities.Enums;

namespace FPT_POLY_CHSARP5.Data.EF.Entities
{
    public class FOrder
    {
        public int Id { set; get; }
        public DateTime OrderDate { set; get; }
        public Guid UserId { set; get; }
        public string ShipName { set; get; }
        public string ShipAddress { set; get; }
        public string ShipEmail { set; get; }
        public string ShipPhoneNumber { set; get; }
        public OrderStatus Status { set; get; }

        public List<FOrderDetail> OrderDetails { get; set; }
    }
}
