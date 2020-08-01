using log4net;
using SansarEmporiamApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SansarEmporiamApplication.Controllers
{
    public class CustomerController : ApiController
    {
        ICustomerRepository customerRepository;
        private readonly ILog log = LogManager.GetLogger("API Logger");

        public CustomerController() : this(new CustomerDetailRepository()) { }

        public CustomerController(ICustomerRepository repository)
        {
            customerRepository = repository;
        }

        [HttpPost]
        public IHttpActionResult PostNewCustomerDetail(tblCustomerDetail customerDetail)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");
                customerRepository.AddCustomerDetail(customerDetail);
                customerRepository.Save();
                log.Info("Log Info Message - Record Saved Successully");
                return Ok();
            }
            catch (Exception ex)
            {
                log.Error("Log Error Message" + ex);
                throw ex;
            }
            finally
            {

            }

        }
        [HttpGet]
        [Route("api/customer/")]
        public IHttpActionResult GetCustomerDetail()
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");
                IList<tblCustomerDetail> customerDetails = null;
                customerDetails = customerRepository.GetAllCustomerDetails().ToList();

                
                

                if (customerDetails.Count == 0)
                {
                    return NotFound();
                }

                log.Info("Log Info Message - Record Retrived Successfully");
                return Ok(customerDetails);
            }
            catch (Exception ex)
            {
                log.Error("Log Error Message" + ex);
                throw ex;
            }
            finally
            {

            }

        }
        [HttpGet]
        [Route("api/customer/{id}")]
        public IHttpActionResult GetCustomerDetailByNaame(string name)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");

                tblCustomerDetail customerDetails = null;

                customerDetails = customerRepository.GetAllCustomerDetailByName(name);

                if (!customerDetails.Equals(0))
                {
                    return NotFound();
                }
                log.Info("Log Info Message - Record Retrived By ID Successully");
                return Ok(customerDetails);
            }
            catch (Exception ex)
            {
                log.Error("Log Error Message" + ex);
                throw ex;
            }
            finally
            {

            }

        }
        [HttpDelete]
        public IHttpActionResult DeleteCustomerDetail(int customerDetail)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");
                customerRepository.DeleteCustomerDetail(customerDetail);
                customerRepository.Save();
                log.Info("Log Info Message - Record Deleted Successully");
                return Ok();
            }
            catch (Exception ex)
            {
                log.Error("Log Error Message" + ex);
                throw ex;
            }
            finally
            {

            }

        }
        [HttpPut]
        public IHttpActionResult UpdateCustomerDetail(tblCustomerDetail customerDetail)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");
                customerRepository.UpdateCustomerDetail(customerDetail);
                customerRepository.Save();
                log.Info("Log Info Message - Record Updated Successully");
                return Ok();
            }
            catch (Exception ex)
            {
                log.Error("Log Error Message" + ex);
                throw ex;
            }
            finally
            {

            }

        }
    }
}
