using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EatOnTimeApi.Models;
using Newtonsoft.Json;

using System.Web.Http.Cors;
using System.Data.Entity.Core.Objects;

namespace EatOnTimeApi.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    public class ValidateLoginController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public IHttpActionResult ValidateLogin(string user , string pass)
        {
            Result result = new Result();
            RDB5Entities nd = new RDB5Entities();
            ObjectParameter res = new ObjectParameter("@result", TypeCode.String);
            ObjectParameter role = new ObjectParameter("@role", TypeCode.String);
            
            try
            {

                nd.VALIDATE_LOGIN(user, pass, res,role);
                
           
                result.result = res.Value.ToString();
                result.result2 = role.Value.ToString();
            }
            catch (Exception ex)
            {
                result.result = ex.Message;
            }
            return Ok(JsonConvert.SerializeObject(result));

        }
    }
}
