using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SansarEmporiamApplication.Models
{
    public class ShopDetailRepository: IShopRepository,
    IDisposable
    {
        SansarEmporiamApplicationEntities context = new SansarEmporiamApplicationEntities();

        public IEnumerable<tblShopDetail> GetAllShopDetails()
        {
            return context.tblShopDetails.ToList();
        }

        public tblShopDetail GetAllShopDetailByID(int id)
        {
            return context.tblShopDetails.Find(id);
        }

        public int AddShopDetails(tblShopDetail ObjBO)
        {
            try
            {
                using (var context = new SansarEmporiamApplicationEntities())
                {
                    context.ProcedureToAddShopDetails(ObjBO.ShopName, ObjBO.OwnerName, ObjBO.ShopAddress, ObjBO.RegistrationNumber, ObjBO.MobileNumber);
                    context.SaveChanges();
                    return ObjBO.ShopID;
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

        public bool DeleteShopDetail(int emp_ID)
        {
            
            try
            {
                using (var context = new SansarEmporiamApplicationEntities())
                {
                    context.ProcedureToDeleteShopDetails(emp_ID); 
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

        public bool UpdateShopDetail(tblShopDetail shopDetail)
        {
            try
            {
                using (var context = new SansarEmporiamApplicationEntities())
                {
                    context.ProcedureToUpdateShopDetails(shopDetail.ShopID,shopDetail.ShopName, shopDetail.OwnerName, shopDetail.ShopAddress, shopDetail.RegistrationNumber, shopDetail.MobileNumber);
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