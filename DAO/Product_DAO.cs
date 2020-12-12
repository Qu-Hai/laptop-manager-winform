using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO
{
    public class Product_DAO
    {
        #region Count ID
        public int CountID()
        {
            int id;
            Entities db = new Entities();
            var result = (from el in db.products select new { id = el.product_id }).Count();
            id = result;
            return id;
        }
        #endregion
        #region CRUD
        public List<Product_DTO> ListProduct()
        {
            List<Product_DTO> list = new List<Product_DTO>();
            Entities db = new Entities();
            var result = (from el in db.products
                          where el.states == true
                          select new
                          {
                              id = el.product_id,
                              fullname = el.full_name,
                              hard = el.hard_drive,
                              ram = el.ram,
                              cpu = el.CPU,
                              color = el.color,
                              total = el.total,
                              amount = el.amount,
                              desc = el.descriptions,
                              images = el.images,
                              sup_id = el.supplier_id,
                              date = el.date_of_manufacture
                          }).ToList();
            foreach (var el in result)
            {

                Product_DTO product = new Product_DTO();
                product.Product_id = el.id;
                product.Full_name = el.fullname;
                product.Hard_drive = el.hard;
                product.Ram = el.ram;
                product.CPU = el.cpu;
                product.Color = el.color;
                product.Total = el.total;
                product.Descriptions = el.desc;
                product.Images = el.images;
                product.Amount = el.amount;
                product.Supplier_id = el.sup_id;
                product.Date_of_manufacture = el.date;
                list.Add(product);
            }
            return list;
        }
        
        public void Insert(Product_DTO dto)
        {
            Entities db = new Entities();
            var product = new product();
            product.product_id = dto.Product_id;
            product.color = dto.Color;
            product.CPU = dto.CPU;
            product.date_of_manufacture = dto.Date_of_manufacture;
            product.descriptions = dto.Descriptions;
            product.full_name = dto.Full_name;
            product.hard_drive = dto.Hard_drive;
            product.ram = dto.Ram;
            product.supplier_id = dto.Supplier_id;
            product.total = dto.Total;
            product.amount = dto.Amount;
            product.states = true;
            db.products.Add(product);
            db.SaveChanges();
        }

        public bool Delete(string id)
        {
            Entities db = new Entities();
            var product = db.products.Find(id);
            if (product != null)
            {
                product.states = false;
                db.SaveChanges();
                return true;

            }
            return false;

        }
        public bool Update(Product_DTO dto)
        {
            Entities db = new Entities();
            var product = db.products.Find(dto.Product_id);
            if (product != null)
            {
                product.product_id = dto.Product_id;
                product.color = dto.Color;
                product.CPU = dto.CPU;
                product.date_of_manufacture = dto.Date_of_manufacture;
                product.descriptions = dto.Descriptions;
                product.full_name = dto.Full_name;
                product.hard_drive = dto.Hard_drive;
                product.ram = dto.Ram;
                product.supplier_id = dto.Supplier_id;
                product.total = dto.Total;
                db.SaveChanges();
                return true;

            }
            return false;

        }
        #endregion
        #region Auto Complete
        public string[] ListAutoComplete()
        {

            Entities db = new Entities();
            var result = (from el in db.products.Where(el => el.states == true) select new { el.full_name, el.product_id }).ToList();
            int sum = result.Count;
            string[] list = new string[sum];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = result[i].full_name + " " + result[i].product_id;
            }
            return list;

        }
        #endregion
        #region Sort
        public List<Product_DTO> ListSort(string name, bool state)
        {
            List<Product_DTO> list = new List<Product_DTO>();
            Entities db = new Entities();
            if (state)
            {
                var result = (from el in db.products.OrderBy(el => (name.Contains("full_name")) ? el.full_name : (name.Contains("ram"))
                              ? el.ram : (name.Equals("id")) ? el.product_id : el.date_of_manufacture).Where(el => el.states == true)
                              select new
                              {
                                  id = el.product_id,
                                  el.total,
                                  full = el.full_name,
                                  el.ram,
                                  supplier = el.supplier_id,
                                  color = el.color,
                                  CPU = el.CPU,
                                  drive = el.hard_drive,
                              }).ToList();
                foreach (var el in result)
                {

                    Product_DTO dto = new Product_DTO();
                    dto.Color = el.color;
                    dto.CPU = el.CPU;
                    dto.Full_name = el.full;
                    dto.Hard_drive = el.drive;
                    dto.Product_id = el.id;
                    dto.Ram = el.ram;
                    dto.Supplier_id = el.supplier;
                    dto.Total = el.total;

                    list.Add(dto);
                }
            }
            else
            {
                var result = (from el in db.products.OrderBy(el => (name.Contains("full_name")) ? el.full_name : (name.Contains("ram"))
                              ? el.ram : (name.Equals("id")) ? el.product_id : el.date_of_manufacture).Where(el => el.states == true)
                              select new
                              {
                                  id = el.product_id,
                                  total = el.total,
                                  full = el.full_name,
                                  ram = el.ram,
                                  supplier = el.supplier_id,
                                  color = el.color,
                                  CPU = el.CPU,
                                  drive = el.hard_drive,
                              }).ToList();
                foreach (var el in result)
                {

                    Product_DTO dto = new Product_DTO();
                    dto.Color = el.color;
                    dto.CPU = el.CPU;
                    dto.Full_name = el.full;
                    dto.Hard_drive = el.drive;
                    dto.Product_id = el.id;
                    dto.Ram = el.ram;
                    dto.Supplier_id = el.supplier;
                    dto.Total = el.total;
                    list.Add(dto);
                }
            }
            return list;
        }
        #endregion
        #region Search
        public List<Product_DTO> Search(string obj)
        {
            List<Product_DTO> list = new List<Product_DTO>();
            Entities db = new Entities();
            foreach (var el in (from el in db.products.Where(el => el.product_id.Equals(obj) || el.full_name.Contains(obj) || el.color.Equals(obj))
                                select new
                                {
                                    id = el.product_id,
                                    total = el.total,
                                    full = el.full_name,
                                    ram = el.ram,
                                    supplier = el.supplier_id,
                                    color = el.color,
                                    CPU = el.CPU,
                                    drive = el.hard_drive,
                                }).ToList())

            {

                Product_DTO dto = new Product_DTO();
                dto.Color = el.color;
                dto.CPU = el.CPU;
                dto.Full_name = el.full;
                dto.Hard_drive = el.drive;
                dto.Product_id = el.id;
                dto.Ram = el.ram;
                dto.Supplier_id = el.supplier;
                dto.Total = el.total;
                list.Add(dto);
            }
            return list;
        }
        #endregion
    }
}
