using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product_DTO
    {
        private string _product_id;
        private string _full_name;
        private string _hard_drive;
        private string _ram;
        private string _CPU;
        private bool _states;
        private string _color;
        private string _descriptions;
        private string _images;
        private string _date_of_manufacture;
        private int _amount;
        private int _total;
        private string _supplier_id;

        
        public string Full_name { get => _full_name; set => _full_name = value; }
        public string Hard_drive { get => _hard_drive; set => _hard_drive = value; }
        public string Ram { get => _ram; set => _ram = value; }
        public string CPU { get => _CPU; set => _CPU = value; }
        public bool States { get => _states; set => _states = value; }
        public string Color { get => _color; set => _color = value; }
        public string Descriptions { get => _descriptions; set => _descriptions = value; }
        public string Images { get => _images; set => _images = value; }
        public string Date_of_manufacture { get => _date_of_manufacture; set => _date_of_manufacture = value; }
        public int Total { get => _total; set => _total = value; }
        public string Supplier_id { get => _supplier_id; set => _supplier_id = value; }
        public int Amount { get => _amount; set => _amount = value; }
        public string Product_id { get => _product_id; set => _product_id = value; }
    }
}
