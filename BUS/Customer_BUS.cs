using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Customer_BUS
    {

        public List<Customer_DTO> List()
        {
            Customer_DAO dao = new Customer_DAO();
            return dao.List();
        }
        public void Insert(Customer_DTO dto)
        {
            Customer_DAO dao = new Customer_DAO();
            dao.Insert(dto);
        }
        public int CountID()
        {
            Customer_DAO dao = new Customer_DAO();
            return dao.CountID();
        }
        public bool Delete(string id)
        {
            Customer_DAO dao = new Customer_DAO();
            return dao.Delete(id);
        }
        public bool Update(Customer_DTO dto)
        {
            Customer_DAO dao = new Customer_DAO();
            return dao.Update(dto);
        }
        public string[] ListAutoComplete()
        {
            Customer_DAO dao = new Customer_DAO();
            return dao.ListAutoComplete();
        }
        public List<Customer_DTO> ListSort(string name,bool state)
        {
            Customer_DAO dao = new Customer_DAO();
            return dao.ListSort(name,state);
        }
        public List<Customer_DTO> Search(string obj)
        {
            Customer_DAO dao = new Customer_DAO();
            return dao.Search(obj);
        }
    }
}
