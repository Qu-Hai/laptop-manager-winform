using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class Customer_DAO
    {
        #region Count ID
        public int CountID()
        {
            int id;
            Entities db = new Entities();
            var result = (from el in db.customers select new { id = el.id }).Count();
            id = result;
            return id;
        }
        #endregion
        #region CRUD
        public List<Customer_DTO> List()
        {
            List<Customer_DTO> list = new List<Customer_DTO>();
            Entities db = new Entities();
            var result = (from el in db.customers.Where(el => el.states == true) select new
                          {
                              id = el.id,
                              last = el.last_name,
                              first = el.firt_name,
                              city = el.city,
                              birth = el.date_of_birth,
                              gender = el.gender,
                              phone = el.phone_number,
                              email = el.email,
                          }).ToList();
            foreach (var el in result)
            {

                Customer_DTO dto = new Customer_DTO();
                dto.Id = el.id;
                dto.Last_name = el.last;
                dto.Firt_name = el.first;
                dto.Date_of_birth = el.birth;
                dto.City = el.city;
                dto.Gender = el.gender;
                dto.Phone_number = el.phone;
                dto.Email = el.email;
                list.Add(dto);
            }
            return list;
        }
        public void Insert(Customer_DTO dto)
        {
            Entities db = new Entities();
            var customer = new customer();
            customer.id = dto.Id;
            customer.last_name = dto.Last_name;
            customer.firt_name = dto.Firt_name;
            customer.city = dto.City;
            customer.date_of_birth = dto.Date_of_birth;
            customer.gender = dto.Gender;
            customer.phone_number = dto.Phone_number;
            customer.email = dto.Email;
            customer.states = true;
            db.customers.Add(customer);
            db.SaveChanges();  
        }
        
        public bool Delete(string id)
        {
            Entities db = new Entities();
            var Customer = db.customers.Find(id);
            if (Customer != null)
            {
                Customer.states = false;
                db.SaveChanges();
                return true;
                
            }
            return false;

        }
        public bool Update(Customer_DTO dto)
        {
            Entities db = new Entities();
            var Customer = db.customers.Find(dto.Id);
            if (Customer != null)
            {
                Customer.id = dto.Id;
                Customer.last_name = dto.Last_name;
                Customer.firt_name = dto.Firt_name;
                Customer.city = dto.City;
                Customer.date_of_birth = dto.Date_of_birth;
                Customer.gender = dto.Gender;
                Customer.phone_number = dto.Phone_number;
                Customer.email = dto.Email;
                Customer.states = true;
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
            var result = (from el in db.customers.Where(el => el.states == true) select new { el.last_name, el.firt_name }).ToList();
            int sum = result.Count;
            string[] list = new string[sum];
            for(int i = 0;i<list.Length;i++)
            {
                list[i] = result[i].last_name + " "+result[i].firt_name;
            }
            return list;

        }
        #endregion
        #region Sort
        public List<Customer_DTO> ListSort(string name, bool state)
        {
            List<Customer_DTO> list = new List<Customer_DTO>();
            Entities db = new Entities();
            if (state)
            {
                var result = (from el in db.customers.OrderBy(el => (name.Equals("firt_name")) ? el.firt_name : (name.Equals("gender")) ? el.gender :(name.Equals("id"))? el.id: el.date_of_birth).Where(el => el.states == true)
                              select new
                              {
                                  id = el.id,
                                  last = el.last_name,
                                  first = el.firt_name,
                                  city = el.city,
                                  birth = el.date_of_birth,
                                  gender = el.gender,
                                  phone = el.phone_number,
                                  email = el.email,
                              }).ToList();
                foreach (var el in result)
                {

                    Customer_DTO dto = new Customer_DTO();
                    dto.Id = el.id;
                    dto.Last_name = el.last;
                    dto.Firt_name = el.first;
                    dto.Date_of_birth = el.birth;
                    dto.City = el.city;
                    dto.Gender = el.gender;
                    dto.Phone_number = el.phone;
                    dto.Email = el.email;
                    list.Add(dto);
                }
            }
            else
            {
               var result = (from el in db.customers.OrderByDescending(el => (name.Equals("firt_name")) ? el.firt_name : (name.Equals("gender")) ? el.gender :(name.Equals("id")) ? el.id : el.date_of_birth).Where(el => el.states == true)
                              select new
                              {
                                  id = el.id,
                                  last = el.last_name,
                                  first = el.firt_name,
                                  city = el.city,
                                  birth = el.date_of_birth,
                                  gender = el.gender,
                                  phone = el.phone_number,
                                  email = el.email,
                              }).ToList();
                foreach (var el in result)
                {

                    Customer_DTO dto = new Customer_DTO();
                    dto.Id = el.id;
                    dto.Last_name = el.last;
                    dto.Firt_name = el.first;
                    dto.Date_of_birth = el.birth;
                    dto.City = el.city;
                    dto.Gender = el.gender;
                    dto.Phone_number = el.phone;
                    dto.Email = el.email;
                    list.Add(dto);
                }
            }
            return list;
        }
        #endregion
        #region Search
        public List<Customer_DTO> Search(string obj)
        {
            List<Customer_DTO> list = new List<Customer_DTO>();
            Entities db = new Entities();
            var result = (from el in db.customers.Where(el => (el.id.Contains(obj)||el.last_name.Contains(obj) || el.firt_name.Contains(obj) || (el.last_name +" "+el.firt_name).Equals(obj)
                                                             || el.date_of_birth.Contains(obj)||el.city.Equals(obj)||el.phone_number.ToString().Equals(obj)))
                          select new
                          {
                              id = el.id,
                              last = el.last_name,
                              first = el.firt_name,
                              city = el.city,
                              birth = el.date_of_birth,
                              gender = el.gender,
                              phone = el.phone_number,
                              email = el.email,
                          }).ToList();
            foreach (var el in result)
            {

                Customer_DTO dto = new Customer_DTO();
                dto.Id = el.id;
                dto.Last_name = el.last;
                dto.Firt_name = el.first;
                dto.Date_of_birth = el.birth;
                dto.City = el.city;
                dto.Gender = el.gender;
                dto.Phone_number = el.phone;
                dto.Email = el.email;
                list.Add(dto);
            }
            return list;
        }
        #endregion
    }
}
