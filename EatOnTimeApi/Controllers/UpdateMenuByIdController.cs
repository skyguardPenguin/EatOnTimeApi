using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EatOnTimeApi.Models;
using Newtonsoft.Json;

namespace EatOnTimeApi.Controllers
{
    public class UpdateMenuByIdController : ApiController
    {
        public IHttpActionResult UpdateMenuById(int id, string productCode, string desc, double price, string tipo)
        {
            Result result = new Result();
            RDB5Entities nd = new RDB5Entities();
            try
            {

                nd.UPDATE_MENU_BY__ID(id, productCode, desc, price, tipo);
                result.result = Constants.OK;
            }
            catch (Exception ex)
            {
                result.result = ex.Message;
            }
            return Ok(JsonConvert.SerializeObject(result));

        }
    }
}
