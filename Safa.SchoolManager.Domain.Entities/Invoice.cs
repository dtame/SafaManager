using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safa.SchoolManager.Domain.Entities
{
    public class Invoice
    {
        public int ID { get; set; }
        public DateTime CreateThe { get; set; }
        public string UserEmail { get; set; }
        public string InvoiceNumber { get; set; }
        public List<Paiement> PaiementList { get; set; } 
    }    
}
