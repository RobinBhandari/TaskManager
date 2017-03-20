using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TaskManager.API.Controllers
{
    [RoutePrefix("api/task")]
    public class TaskController : ApiController
    {

        [Route("")]
        public object Post(Models.TaskItem newTask) {

            // Save task to repository here
            return this.Created<Models.TaskItem>("api/task/" + newTask.TaskID, newTask);


        }


        [Route("{id}")]
        public object Get(Guid id) {

            return null;


        }

    }
}
