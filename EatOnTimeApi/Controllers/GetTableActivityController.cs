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
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class GetTableActivityController : ApiController
    {
        public IHttpActionResult GetTableActivity(int id)
        {
            Result result = new Result();
            RDB5Entities nd = new RDB5Entities();
            IList<TableActivity> tableDetails;
            try
            {

                tableDetails = nd.GET_TABLE_ACTIVITY(id).Select(x => new TableActivity()
                {
                    Status = x.STATUS,
                    Qty = x.QTY,
                    StartTime = x.START_TIME,
                    EstTime = x.EST_TIME
                }).ToList<TableActivity>();

                result.data = tableDetails;
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
