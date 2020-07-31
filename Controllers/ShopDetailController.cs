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
    public class ShopDetailController : ApiController
    {
        IShopRepository shopRepository;
        private readonly ILog log = LogManager.GetLogger("API Logger");

        public ShopDetailController() : this(new ShopDetailRepository()) { }

        public ShopDetailController(IShopRepository repository)
        {
            shopRepository = repository;
        }
            
        [HttpPost]
        public IHttpActionResult PostNewShopDetail(tblShopDetail shopDetail)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");
                    shopRepository.AddShopDetails(shopDetail);
                    shopRepository.Save();
                    return Ok();
            }
            catch (Exception ex )
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
                IList<tblShopDetail> shopDetails = null;
                shopDetails = shopRepository.GetAllShopDetails().ToList();

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
        [Route("api/shopdetail/{id}")]
        public IHttpActionResult GetShopDetailByID(int shopID)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");

                tblShopDetail shopDetails = null;

                shopDetails = shopRepository.GetAllShopDetailByID(shopID);

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
        public IHttpActionResult DeletShopDetail(int ShopID)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");
                shopRepository.DeleteShopDetail(ShopID);
                shopRepository.Save();
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
        public IHttpActionResult UpdateShopDetail(tblShopDetail shopDetail)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");
                shopRepository.UpdateShopDetail(shopDetail);
                shopRepository.Save();
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
