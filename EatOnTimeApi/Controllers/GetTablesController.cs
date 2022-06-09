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
    public class GetTablesController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public IHttpActionResult GetTables()
        {
            Result result = new Result();
            RDB5Entities nd= new RDB5Entities();
            IList<TableDetail> tableDetails;
            try
            {
                
                tableDetails = nd.API_PROC_GET_TABLES().Select(x => new TableDetail()
                {
                    TableId = x.TABLE_ID,
                    TableStatus = x.TABLE_STATUS,
                    EstTime = x.EST_TIME,
                    QtyLimit = x.QTY_LIMIT
                }).ToList<TableDetail>();

                result.data = tableDetails;
                result.result = Constants.OK;
            }
            catch(Exception ex)
            {
                result.result = ex.Message;
            }
            return Ok(JsonConvert.SerializeObject(result));



        }

    }
}
