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
        public IHttpActionResult PostNewShopDetail(tblCustomerDetail customerDetail)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");
                customerRepository.AddCustomerDetail(customerDetail);
                customerRepository.Save();
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }

        }
        [HttpGet]
        [Route("api/customers/")]
        public IHttpActionResult GetShopDetail()
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");
                IList<tblCustomerDetail> shopDetails = null;
                shopDetails = customerRepository.GetAllCustomerDetails().ToList();

                log.Info("Log Info Message");
                log.Debug("Log Debug Message");
                log.Error("Log Error Message");
                log.Warn("Log Warning Message");

                if (shopDetails.Count == 0)
                {
                    return NotFound();
                }


                return Ok(shopDetails);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }

        }
        [HttpGet]
        [Route("api/customer/{id}")]
        public IHttpActionResult GetShopDetailByID(string name)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");

                tblCustomerDetail shopDetails = null;

                shopDetails = customerRepository.GetAllCustomerDetailByName(name);

                if (!shopDetails.Equals(0))
                {
                    return NotFound();
                }
                return Ok(shopDetails);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }

        }
        [HttpDelete]
        public IHttpActionResult DeletShopDetail(int customerDetail)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");
                customerRepository.DeleteCustomerDetail(customerDetail);
                customerRepository.Save();
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }

        }
        [HttpPut]
        public IHttpActionResult UpdateShopDetail(tblCustomerDetail customerDetail)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");
                customerRepository.UpdateCustomerDetail(customerDetail);
                customerRepository.Save();
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }

        }
    }
}
