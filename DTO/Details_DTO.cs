using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Details_DTO
    {
        private string _invoice_id;
        private string _product_id;
        private int _total;

        public string Invoice_id { get => _invoice_id; set => _invoice_id = value; }
        public string Product_id { get => _product_id; set => _product_id = value; }
        public int Total { get => _total; set => _total = value; }
    }
}
