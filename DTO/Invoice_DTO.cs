using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Invoice_DTO
    {
        private string _invoice_id;
        private string _staff_id;
        private string _customer_id;
        private string _create_at;

        public string Invoice_id { get => _invoice_id; set => _invoice_id = value; }
        public string Staff_id { get => _staff_id; set => _staff_id = value; }
        public string Customer_id { get => _customer_id; set => _customer_id = value; }
        public string Create_at { get => _create_at; set => _create_at = value; }
    }
}
