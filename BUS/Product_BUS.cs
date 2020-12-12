using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Product_BUS
    {
        public List<Product_DTO> ListProduct()
        {
            Product_DAO dao = new Product_DAO();
            return dao.ListProduct();
        }
        public int CountID()
        {
            Product_DAO dao = new Product_DAO();
            return dao.CountID();
        }
        public bool Delete(string id)
        {
            Product_DAO dao = new Product_DAO();
            return dao.Delete(id);
        }
        public bool Update(Product_DTO dto)
        {
            Product_DAO dao = new Product_DAO();
            return dao.Update(dto);
        }
        public void Insert(Product_DTO dto)
        {
            Product_DAO dao = new Product_DAO();
            dao.Insert(dto);
        }
        public string[] ListAutoComplete()
        {
            Product_DAO dao = new Product_DAO();
            return dao.ListAutoComplete();
        }
        public List<Product_DTO> ListSort(string name, bool state)
        {
            Product_DAO dao = new Product_DAO();
            return dao.ListSort(name, state);
        }
        public List<Product_DTO> Search(string obj)
        {
            Product_DAO dao = new Product_DAO();
            return dao.Search(obj);
        }
    }
}
