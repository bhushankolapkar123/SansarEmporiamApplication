using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SansarEmporiamApplication.Models
{
    public interface IWholeSellerRepository: IDisposable
    {
        IEnumerable<tblWholeSellerDetail> GetAllWholeSellerDetails();
        tblWholeSellerDetail GetAllWholeSellerDetailByID(int emp_ID);
        int AddWholeSellerDetails(tblWholeSellerDetail emp);
        bool DeleteWholeSellerDetail(int emp_ID);
        bool UpdateWholeSellerDetail(tblWholeSellerDetail emp);
        int Save();
    }
}