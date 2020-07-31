using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SansarEmporiamApplication.Models
{
    public class CustomerDetailRepository:ICustomerRepository,IDisposable
    {
        SansarEmporiamApplicationEntities context = new SansarEmporiamApplicationEntities();

        public IEnumerable<tblCustomerDetail> GetAllCustomerDetails()
        {
            return context.tblCustomerDetails.ToList();
        }

        public tblCustomerDetail GetAllCustomerDetailByName(string name)
        {
            return context.tblCustomerDetails.Find(name);
        }

        public int AddCustomerDetail(tblCustomerDetail ObjBO)
        {
            try
            {
                using (var context = new SansarEmporiamApplicationEntities())
                {
                    context.ProcedureToAddCustomerDetails(ObjBO.FirstName, ObjBO.LastName, ObjBO.MobileNumber, ObjBO.EmailID, ObjBO.City, ObjBO.CustomerAddress,
                                                         ObjBO.PurchaseItem, ObjBO.PurchaseDate, ObjBO.TotalAmount, ObjBO.PaidAmount, ObjBO.Balance, ObjBO.DueDate, ObjBO.RemainderMessage);
                    context.SaveChanges();
                    return ObjBO.CustomerID;
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

        public bool DeleteCustomerDetail(int CustomerID)
        {

            try
            {
                using (var context = new SansarEmporiamApplicationEntities())
                {
                    context.ProcedureToDeleteCustmerDetail(CustomerID);
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

        public bool UpdateCustomerDetail(tblCustomerDetail customerDetail)
        {
            try
            {
                using (var context = new SansarEmporiamApplicationEntities())
                {
                    context.ProcedureToUpdateCustomerDetail(customerDetail.CustomerID, customerDetail.FirstName, customerDetail.LastName, customerDetail.MobileNumber, customerDetail.EmailID, customerDetail.City, customerDetail.CustomerAddress,
                                                         customerDetail.PurchaseItem, customerDetail.PurchaseDate, customerDetail.TotalAmount, customerDetail.PaidAmount, customerDetail.Balance, customerDetail.DueDate, customerDetail.RemainderMessage);
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