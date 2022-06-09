using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using EatOnTimeApi.Models;
using Newtonsoft.Json;
namespace EatOnTimeApi.Controllers
{
    public class InsertIntoOrderController : ApiController    
    {
        public IHttpActionResult InsertIntoOrder (int id, string productCode, int qty)
        {
            Result result = new Result();
            RDB5Entities nd = new RDB5Entities();
            IList<TableActivity> tableDetails;
            try
            {
                nd.INSERT_ORDER(id, productCode, qty);
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
