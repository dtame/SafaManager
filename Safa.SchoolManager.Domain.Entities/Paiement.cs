using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safa.SchoolManager.Domain.Entities
{
    public class Paiement
    {
        public int ID { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime CreateThe { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
    }
}
