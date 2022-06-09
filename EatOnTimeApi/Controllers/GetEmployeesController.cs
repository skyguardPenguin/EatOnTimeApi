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
    public class GetEmployeesController : ApiController
    {

        public IHttpActionResult GetEmployees()
        {
            Result result = new Result();
            RDB5Entities nd = new RDB5Entities();
            IList<User> tableDetails;
            try
            {

                tableDetails = nd.GET_EMPLOYEES().Select(x => new User()
                {
                    UserId = x.R_USER_ID.ToString(),
                    UserName = x.R_USER_NAME,
                    UserRole = x.USER_ROLE,
                    CreatedOn = x.CREATED_ON.ToString()
                }).ToList<User>();

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
