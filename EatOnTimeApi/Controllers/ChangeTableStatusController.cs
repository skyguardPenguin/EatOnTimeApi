using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EatOnTimeApi.Models;
using Newtonsoft.Json;
namespace EatOnTimeApi.Controllers
{
    public class ChangeTableStatusController : ApiController
    {
        public IHttpActionResult GetTableActivity(int id, int qty)
        {
            Result result = new Result();
            RDB5Entities nd = new RDB5Entities();
            ObjectParameter obj = new ObjectParameter("order_id",TypeCode.String);
            try
            {

                nd.CHANGE_TABLE_STATUS(id, qty,obj);

              
                result.result = obj.Value.ToString();
            }
            catch (Exception ex)
            {
                result.result = ex.Message;
            }
            return Ok(JsonConvert.SerializeObject(result));

        }
    }
}
