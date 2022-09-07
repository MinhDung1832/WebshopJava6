using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NET105_Tutorial_Csharp5_Dungna29.Models.FluentApi_Model.Enums;

namespace NET105_Tutorial_Csharp5_Dungna29.Models.FluentApi_Model
{
    public class FTransaction
    {
        public int Id { set; get; }
        public DateTime TransactionDate { set; get; }
        public string ExternalTransactionId { set; get; }
        public decimal Amount { set; get; }
        public decimal Fee { set; get; }
        public string Result { set; get; }
        public string Message { set; get; }
        public TransactionStatus Status { set; get; }
        public string Provider { set; get; }
    }
}
