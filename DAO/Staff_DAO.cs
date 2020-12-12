using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BCrypt.Net;
namespace DAO
{
    public class Staff_DAO
    {
        #region Count ID
        public int CountID()
        {
            int id;
            Entities db = new Entities();
            var result = (from el in db.staffs select new { vl = el.id }).Count();
            id = result;
            return id;
        }
        #endregion
        #region CRUD
        public List<Staff_DTO> ListStaff()
        {
            List<Staff_DTO> list = new List<Staff_DTO>();
            Entities db = new Entities();
            foreach (var el in (from el in db.staffs.Where(el => el.states == true)
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
                                   position = el.position,
                                   create = el.create_at,

                               }).ToList())
            {

                Staff_DTO dto = new Staff_DTO();
                dto.Id = el.id;
                dto.Last_name = el.last;
                dto.Firt_name= el.first;
                dto.City = el.city;
                dto.Date_of_birth = el.birth;
                dto.Gender = el.gender;
                dto.Phone_number = el.phone;
                dto.Email = el.email;
                dto.Position = el.position;
                dto.Create_at = el.create;
                list.Add(dto);
            }
            return list;
        }
        public void Insert(Staff_DTO dto)
        {
            Entities db = new Entities();
            var staff = new staff();
            staff.id = dto.Id;
            staff.last_name = dto.Last_name;
            staff.firt_name = dto.Firt_name;
            staff.city = dto.City;
            staff.date_of_birth = dto.Date_of_birth;
            staff.gender = dto.Gender;
            staff.phone_number = dto.Phone_number;
            staff.email = dto.Email;
            staff.states = true;
            staff.position = "Nhân viên";
            staff.username = dto.Username;
            staff.pass = BCrypt.Net.BCrypt.HashPassword(dto.Password, 12);
            db.staffs.Add(staff);
            db.SaveChanges();
        }

        public bool Delete(string id)
        {
            Entities db = new Entities();
            var staff = db.staffs.Find(id);
            if (staff != null)
            {
                staff.states = false;
                db.SaveChanges();
                return true;

            }
            return false;

        }
        public bool Update(Staff_DTO dto)
        {
            Entities db = new Entities();
            var staff = db.staffs.Find(dto.Id);
            if (staff != null)
            {
                staff.id = dto.Id;
                staff.last_name = dto.Last_name;
                staff.firt_name = dto.Firt_name;
                staff.city = dto.City;
                staff.date_of_birth = dto.Date_of_birth;
                staff.gender = dto.Gender;
                staff.phone_number = dto.Phone_number;
                staff.email = dto.Email;
                staff.states = true;
                staff.position = dto.Position;
                db.SaveChanges();
                return true;

            }
            return false;

        }
        #endregion
        #region Login
        public Staff_DTO Login(string username)
        {
            Staff_DTO dto = new Staff_DTO();
            Entities db = new Entities();
            var result = (from el in db.staffs where el.username == username 
                          select new
                          {
                              id = el.id,
                              last = el.last_name,
                              first = el.firt_name,
                              username = el.username,
                              password = el.pass,
                              position = el.position
                          }).ToList();
            foreach(var el in result)
            {
                dto.Id = el.id;
                dto.Last_name = el.last;
                dto.Firt_name = el.first;
                dto.Username = el.username;
                dto.Password = el.password;
                dto.Position = el.position;
            }
            return dto;
        }
        #endregion
        #region Auto Complete
        public string[] ListAutoComplete()
        {

            Entities db = new Entities();
            var result = (from el in db.staffs.Where(el => el.states == true) select new { el.last_name, el.firt_name }).ToList();
            int sum = result.Count;
            string[] list = new string[sum];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = result[i].last_name + " " + result[i].firt_name;
            }
            return list;

        }
        #endregion
        #region Sort
        public List<Staff_DTO> ListSort(string name, bool state)
        {
            List<Staff_DTO> list = new List<Staff_DTO>();
            Entities db = new Entities();
            if (state)
            {
                var result = (from el in db.staffs.OrderBy(el => (name.Equals("firt_name")) ? el.firt_name : (name.Equals("gender")) ? el.gender : (name.Equals("id")) ? el.id : el.date_of_birth).Where(el => el.states == true)
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

                    Staff_DTO dto = new Staff_DTO();
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
                var result = (from el in db.staffs.OrderByDescending(el => (name.Equals("firt_name")) ? el.firt_name : (name.Equals("gender")) ? el.gender : (name.Equals("id")) ? el.id : el.date_of_birth).Where(el => el.states == true)
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

                    Staff_DTO dto = new Staff_DTO();
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
        public List<Staff_DTO> Search(string obj)
        {
            List<Staff_DTO> list = new List<Staff_DTO>();
            Entities db = new Entities();
            var result = (from el in db.staffs.Where(el => (el.id.Contains(obj) || el.last_name.Contains(obj) || el.firt_name.Contains(obj) || (el.last_name + " " + el.firt_name).Equals(obj)
                                                             || el.date_of_birth.Contains(obj) || el.city.Equals(obj) || el.phone_number.ToString().Equals(obj)))
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

                Staff_DTO dto = new Staff_DTO();
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
