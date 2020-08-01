using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SansarEmporiamApplication.Models
{
    public interface IStockRepository: IDisposable
    {
        IEnumerable<tblStockDetail> GetAllStockDetails();
        tblStockDetail GetAllStockDetailByID(int emp_ID);
        int AddStockDetails(tblStockDetail emp);
        bool DeleteStockDetail(int emp_ID);
        bool UpdateStockDetail(tblStockDetail emp);
        int Save();
    }
}