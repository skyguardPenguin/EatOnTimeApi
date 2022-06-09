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
    public class GetCheckController : ApiController
    {
        public IHttpActionResult GetTableActivity(int id)
        {
            Result result = new Result();
            RDB5Entities nd = new RDB5Entities();
            ObjectParameter total = new ObjectParameter("out_total",TypeCode.String);
            ObjectParameter subtotal = new ObjectParameter("out_subtotal",TypeCode.String);
            try
            {

                nd.GET_CHECK(id, total, subtotal);

                Check check = new Check()
                {
                    OrderId = id.ToString(),
                    Total = total.Value.ToString(),
                    Subtotal = subtotal.Value.ToString()

                };
                result.data = check;
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
