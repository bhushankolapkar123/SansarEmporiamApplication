using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace SansarEmporiamApplication.Models
{
    public interface IShopRepository : IDisposable
    {
        IEnumerable<tblShopDetail> GetAllShopDetails();
        tblShopDetail GetAllShopDetailByID(int emp_ID);
        int AddShopDetails(tblShopDetail emp);
        bool DeleteShopDetail(int emp_ID);
        bool UpdateShopDetail(tblShopDetail emp);
        int Save();

        
    }
}