using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EatOnTimeApi.Models;
using Newtonsoft.Json;
using System.Data.Entity.Core.Objects;
using System.Web.Http.Cors;
namespace EatOnTimeApi.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class ValidateLoginController : ApiController
    {
        public IHttpActionResult ValidateLogin(string user , string pass)
        {
            Result result = new Result();
            RDB5Entities nd = new RDB5Entities();
            ObjectParameter res = new ObjectParameter("@result", TypeCode.String);
            try
            {

                nd.VALIDATE_LOGIN(user, pass, res);
                
           
                result.result = res.Value.ToString();
            }
            catch (Exception ex)
            {
                result.result = ex.Message;
            }
            return Ok(JsonConvert.SerializeObject(result));

        }
    }
}
