using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SansarEmporiamApplication.Models
{
    public class WholeSellerDetailRepository:IWholeSellerRepository, IDisposable
    {

        SansarEmporiamApplicationEntities context = new SansarEmporiamApplicationEntities();

        public IEnumerable<tblWholeSellerDetail> GetAllWholeSellerDetails()
        {
            return context.tblWholeSellerDetails.ToList();
        }

        public tblWholeSellerDetail GetAllWholeSellerDetailByID(int id)
        {
            return context.tblWholeSellerDetails.Find(id);
        }

        public int AddWholeSellerDetails(tblWholeSellerDetail ObjBO)
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

        public bool DeleteWholeSellerDetail(int emp_ID)
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

        public bool UpdateWholeSellerDetail(tblWholeSellerDetail shopDetail)
        {
            try
            {
                using (var context = new SansarEmporiamApplicationEntities())
                {
                    context.ProcedureToUpdateShopDetails(shopDetail.ShopID, shopDetail.ShopName, shopDetail.OwnerName, shopDetail.ShopAddress, shopDetail.RegistrationNumber, shopDetail.MobileNumber);
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
