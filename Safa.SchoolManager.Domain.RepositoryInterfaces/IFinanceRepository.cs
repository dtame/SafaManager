using Safa.SchoolManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safa.SchoolManager.Domain.RepositoryInterfaces
{
    public interface IFinanceRepository
    {
        Invoice GetInvoiceByUser(string email);
        Invoice GetInvoiceByNumber(string invoicenumber);
        bool AddInvoice(Invoice invoice, double amount, string description); 
    }
}
