using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class Staff_BUS
    {
       
        public List<Staff_DTO> ListStaff()
        {
            Staff_DAO dao = new Staff_DAO();
            return dao.ListStaff();
        }
        public Staff_DTO Login(string username)
        {
            Staff_DAO dao = new Staff_DAO();
            return dao.Login(username);
        }
        public void Insert(Staff_DTO dto)
        {
            Staff_DAO dao = new Staff_DAO();
            dao.Insert(dto);
        }
        public int CountID()
        {
            Staff_DAO dao = new Staff_DAO();
            return dao.CountID();
        }
        public bool Delete(string id)
        {
            Staff_DAO dao = new Staff_DAO();
            return dao.Delete(id);
        }
        public bool Update(Staff_DTO dto)
        {
            Staff_DAO dao = new Staff_DAO();
            return dao.Update(dto);
        }
        public string[] ListAutoComplete()
        {
            Staff_DAO dao = new Staff_DAO();
            return dao.ListAutoComplete();
        }
        public List<Staff_DTO> ListSort(string name, bool state)
        {
            Staff_DAO dao = new Staff_DAO();
            return dao.ListSort(name, state);
        }
        public List<Staff_DTO> Search(string obj)
        {
            Staff_DAO dao = new Staff_DAO();
            return dao.Search(obj);
        }
    }
}
