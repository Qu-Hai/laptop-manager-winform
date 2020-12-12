using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Invoice_BUS
    {
        public int CountID()
        {
            Invoice_DAO dao = new Invoice_DAO();
            return dao.CountID();
        }
        public void Insert(Invoice_DTO dto)
        {
            Invoice_DAO dao = new Invoice_DAO();
            dao.Insert(dto);
        }
        public bool Delete(string id)
        {
            Invoice_DAO dao = new Invoice_DAO();
            return dao.Delete(id);
        }
        public List<Report_Invoice_DTO> ListInvoice(string query)
        {
            Invoice_DAO dao = new Invoice_DAO();
            return dao.ListInvoice(query);
        }
    }
}
