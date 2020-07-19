using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessObject;
using DataAccessLibrary;
using BusinessLogicLibrary;

namespace SansarEmporiamApplication.Controllers
{
    public class ShopDetailController : ApiController
    {
        public IHttpActionResult PostNewStudent(tblShopDetail student)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            tblShopDetail ObjUBO = new tblShopDetail();


            ObjUBO.ShopName = student.ShopName;
            ObjUBO.ShopAddress = student.ShopAddress;
            ObjUBO.OwnerName = student.OwnerName;
            ObjUBO.RegistrationNumber = student.RegistrationNumber;
            ObjUBO.MobileNumber = student.MobileNumber;

            BusinessLogic objUBL = new BusinessLogic();

            int result = objUBL.SaveUserregisrationBL(ObjUBO);


            return Ok();
        }
    }
}
