using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace SansarEmporiamApplication.Models
{
    public interface ICustomerRepository : IDisposable
    {
        IEnumerable<tblCustomerDetail> GetAllCustomerDetails();
        tblCustomerDetail GetAllCustomerDetailByName(string name);
        int AddCustomerDetail(tblCustomerDetail emp);
        bool DeleteCustomerDetail(int CustomerID);
        bool UpdateCustomerDetail(tblCustomerDetail emp);
        int Save();
    }
}