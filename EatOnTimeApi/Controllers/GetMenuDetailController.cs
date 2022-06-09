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
    public class GetMenuDetailController : ApiController
    {
        public IHttpActionResult GetMenuDetail(int id)
        {
            Result result = new Result();
            RDB5Entities nd = new RDB5Entities();
            IList<MenuDetail>detail;
            try
            {

                detail = nd.GET_MENU_DETAIL_BY_ID(id).Select(x => new MenuDetail()
                {
                    
                    ProductCode =x.PRODUCT_CODE,
                    ProductDesc = x.PRODUCT_DESC,
                    ProductName =x.PRODUCT_NAME,
                    ProductType =x.PRODUCT_TYPE
                }).ToList<MenuDetail>();

                result.data = detail ;
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
