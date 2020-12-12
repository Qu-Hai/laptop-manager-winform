using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Report_Invoice_DTO
    {
        private string idS;
        private string idC;
        private string _cus_name;
        private string _sta_name;
        private string _full_name;
        private int? _total;
        private int? _amount;
        private string _create_at;
        private int? _price;

        public string Cus_name { get => _cus_name; set => _cus_name = value; }
        public string Full_name { get => _full_name; set => _full_name = value; }
        public int? Total { get => _total; set => _total = value; }
        public int? Amount { get => _amount; set => _amount = value; }
        public string Create_at { get => _create_at; set => _create_at = value; }
        public string Sta_name { get => _sta_name; set => _sta_name = value; }
        public string IdS { get => idS; set => idS = value; }
        public string IdC { get => idC; set => idC = value; }
        public int? Price { get => _price; set => _price = value; }
    }
}
