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
    public class GetMenuController : ApiController
    {
        public IHttpActionResult GetTableActivity(int id)
        {
            Result result = new Result();
            RDB5Entities nd = new RDB5Entities();
            IList<Menu> menus;
            try
            {

                menus = nd.GET_MENU_BY_ID(id).Select(x => new Menu()
                {
                    MenuId =x.MENU_ID,
                    MenuTitle = x.MENU_TITLE
                }).ToList<Menu>();

                result.data = menus;
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
