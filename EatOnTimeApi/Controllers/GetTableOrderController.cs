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
    public class GetTableOrderController : ApiController
    {
        public IHttpActionResult GetTableOrder(int tableId)
        {
            Result result = new Result();
            RDB5Entities nd = new RDB5Entities();
            IList<TableOrder> tableDetails;
            try
            {

                tableDetails = nd.P_GET_TABLE_ORDER(tableId).Select(x => new TableOrder()
                {
                    OrderId = x.ORDER_ID.ToString(),
                    ProductCode = x.PRODUCT_CODE,
                    ProductName = x.PRODUCT_NAME,
                    UnitPrice = x.UNIT_PRICE.ToString(),
                    QtyPO = x.QTY_PO.ToString(),
                    Served = x.SERVED,
                    CreatedOn = x.CREATED_ON.ToString()
     
                }).ToList<TableOrder>();

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
