using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Invoice_DAO
    {
        public int CountID()
        {
            int id;
            Entities db = new Entities();
            var result = (from el in db.invoices select new { id = el.invoice_id }).Count();
            id = result;
            return id;
        }
        public void Insert(Invoice_DTO dto)
        {
            Entities db = new Entities();
            var invoice = new invoice();
            invoice.invoice_id = dto.Invoice_id;
            invoice.staff_id = dto.Staff_id;
            invoice.customer_id = dto.Customer_id;
            invoice.create_at = dto.Create_at;
            db.invoices.Add(invoice);
            db.SaveChanges();
        }
        public bool Delete(string id)
        {
            Entities db = new Entities();
            var invoices = db.invoices.Find(id);
            if (invoices != null)
            {
                invoices.states = false;
                db.SaveChanges();
                return true;

            }
            return false;

        }
        public List<Report_Invoice_DTO> ListInvoice(string query)
        {
            List<Report_Invoice_DTO> list = new List<Report_Invoice_DTO>();
            Entities db = new Entities();
            var result = (from i in db.invoices
                          from d in db.details
                          from p in db.products
                          from s in db.staffs
                          from c in db.customers
                          where (d.invoice_id == query && d.product_id == p.product_id)
                            && (i.staff_id == s.id && i.invoice_id == d.invoice_id) && (i.customer_id == c.id)
                          select new { idS = s.id,sta=s.last_name+" "+ s.firt_name,idC=c.id, cus = c.last_name+" "+c.firt_name,full= p.full_name,total= p.total,amount= d.amount,create= i.create_at }).ToList();
            
            foreach(var el in result)
            {
                Report_Invoice_DTO dto = new Report_Invoice_DTO();
                dto.IdS = el.idS;
                dto.IdC = el.idC;
                dto.Sta_name = el.sta;
                dto.Cus_name = el.full;
                dto.Total = el.total;
                dto.Amount = el.amount;
                dto.Create_at = el.create;
                dto.Price = el.total * el.amount;
                list.Add(dto);
            }
                
            
            return list;
        }
    }
}
