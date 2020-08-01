using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SansarEmporiamApplication.Models
{
    public class StockDetailRepository :IStockRepository,IDisposable
    {

        SansarEmporiamApplicationEntities context = new SansarEmporiamApplicationEntities();

        public IEnumerable<tblStockDetail> GetAllStockDetails()
        {
            return context.tblStockDetails.ToList();
        }

        public tblStockDetail GetAllStockDetailByID(int id)
        {
            return context.tblStockDetails.Find(id);
        }

        public int AddStockDetails(tblStockDetail ObjBO)
        {
            try
            {
                using (var context = new SansarEmporiamApplicationEntities())
                {
                    context.ProcedureToAddStockDetail(ObjBO.ItemName, ObjBO.WholeSellPrice, ObjBO.SellingPrice, ObjBO.NumberOfCount, ObjBO.Weight);
                    context.SaveChanges();
                    return ObjBO.StockID;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {


            }
        }

        public bool DeleteStockDetail(int emp_ID)
        {

            try
            {
                using (var context = new SansarEmporiamApplicationEntities())
                {
                    context.ProcedureToDeleteStockDetails(emp_ID);
                    context.SaveChanges();
                    return true;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {


            }
        }

        public bool UpdateStockDetail(tblStockDetail stockDetail)
        {
            try
            {
                using (var context = new SansarEmporiamApplicationEntities())
                {
                    context.ProcedureToUpdateStockDetail(stockDetail.StockID, stockDetail.ItemName, stockDetail.WholeSellPrice, stockDetail.SellingPrice, stockDetail.NumberOfCount, stockDetail.Weight);
                    context.SaveChanges();
                    return true;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {


            }
        }

        public int Save()
        {
            return context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}