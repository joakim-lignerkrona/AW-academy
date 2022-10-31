using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning6_Fortsättning {
    public class Transaction {
        public int transactionID { get; set; }
        public TransactionType type { get; set; }
        public double amount { get; set; }
        public string? fromID { get; set; }
        public string? toID { get; set; }
        public Transaction(int transactionID, TransactionType type, double amount, string fromID, string toID) {
            this.transactionID = transactionID;
            this.type = type;
            this.amount = amount;
            this.fromID = fromID;
            this.toID = toID;
        }
        public Transaction(int transactionID, TransactionType type, double amount) {
            this.transactionID = transactionID;
            this.type = type;
            this.amount = amount;
        }
    }
}
