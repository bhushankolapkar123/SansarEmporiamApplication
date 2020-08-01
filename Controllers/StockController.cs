using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using log4net;
using SansarEmporiamApplication.Models;

namespace SansarEmporiamApplication.Controllers
{
    public class StockController : ApiController
    {
        IStockRepository stockRepository;
        private readonly ILog log = LogManager.GetLogger("API Logger");

        public StockController() : this(new StockDetailRepository()) { }

        public StockController(IStockRepository repository)
        {
            stockRepository = repository;
        }

        [HttpPost]
        public IHttpActionResult PostNewStockDetail(tblStockDetail customerDetail)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");
                stockRepository.AddStockDetails(customerDetail);
                stockRepository.Save();
                log.Info("Log Info Message - Records Saved Successfully");
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
        [Route("api/stock/")]
        public IHttpActionResult GetStockDetail()
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");
                IList<tblStockDetail> customerDetails = null;
                customerDetails = stockRepository.GetAllStockDetails().ToList();
                if (customerDetails.Count == 0)
                {
                    return NotFound();
                }

                log.Info("Log Info Message - Records Retrived Successfully");
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
        [Route("api/stock/{id}")]
        public IHttpActionResult GetStockDetailByNaame(int id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");

                tblStockDetail customerDetails = null;

                customerDetails = stockRepository.GetAllStockDetailByID(id);

                if (!customerDetails.Equals(0))
                {
                    return NotFound();
                }
                log.Info("Log Info Message - Records Retrived By ID Successfully");
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
        public IHttpActionResult DeleteStockItemDetail(int customerDetail)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");
                stockRepository.DeleteStockDetail(customerDetail);
                stockRepository.Save();
                log.Info("Log Info Message - Records Deleted Successfully");
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
        public IHttpActionResult UpdateStockItemDetail(tblStockDetail customerDetail)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid data.");
                stockRepository.UpdateStockDetail(customerDetail);
                stockRepository.Save();
                log.Info("Log Info Message - Records Updated Successfully");
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
