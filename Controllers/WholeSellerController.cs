using SansarEmporiamApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using log4net;

namespace SansarEmporiamApplication.Controllers
{
    public class WholeSellerController : ApiController
    {
        IWholeSellerRepository wholeSellerRepository;
        private readonly ILog log = LogManager.GetLogger("API Logger");

        public WholeSellerController() : this(new WholeSellerDetailRepository()) { }

        public WholeSellerController(IWholeSellerRepository repository)
        {
            wholeSellerRepository = repository;
        }

        [HttpPost]
        public IHttpActionResult PostNewWholeSellerDetail(tblWholeSellerDetail shopDetail)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");
                wholeSellerRepository.AddWholeSellerDetails(shopDetail);
                wholeSellerRepository.Save();
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
        [Route("api/wholeseller/")]
        public IHttpActionResult GetWholeSellerDetail()
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");
                IList<tblWholeSellerDetail> shopDetails = null;
                shopDetails = wholeSellerRepository.GetAllWholeSellerDetails().ToList();
                if (shopDetails.Count == 0)
                {
                    return NotFound();
                }
                log.Info("Log Info Message - Record Retrived Successully");
                return Ok(shopDetails);
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
        [Route("api/wholeseller/{id}")]
        public IHttpActionResult GetWholeSellerDetailByID(int shopID)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");

                tblWholeSellerDetail shopDetails = null;

                shopDetails = wholeSellerRepository.GetAllWholeSellerDetailByID(shopID);

                if (!shopDetails.Equals(0))
                {
                    return NotFound();
                }
                log.Info("Log Info Message - Record Retrived By ID Successully");
                return Ok(shopDetails);
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
        public IHttpActionResult DeleteWholeSellerDetail(int ShopID)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");
                wholeSellerRepository.DeleteWholeSellerDetail(ShopID);
                wholeSellerRepository.Save();
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
        public IHttpActionResult UpdateWholeSellerDetail(tblWholeSellerDetail shopDetail)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");
                wholeSellerRepository.UpdateWholeSellerDetail(shopDetail);
                wholeSellerRepository.Save();
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
