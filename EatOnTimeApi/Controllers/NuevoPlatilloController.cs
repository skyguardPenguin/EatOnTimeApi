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
    public class NuevoPlatilloController : ApiController
    {

        public IHttpActionResult NuevoPlatillo(string desc, float precio, string tipo,int status)
        {
            Result result = new Result();
            RDB5Entities nd = new RDB5Entities();
            try
            {

                nd.NUEVO_PLATILLO(desc, precio, tipo,status);
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
