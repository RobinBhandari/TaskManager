using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TaskManager.API.Models;

namespace TaskManager.API.Controllers {
    [RoutePrefix("api/task")]
    public class TaskController : ApiController {
        private static List<TaskItem> _tasks = new List<TaskItem>();



        [Route("")]
        public object Post(Models.TaskItem newTask) {


            newTask.TaskID = Guid.NewGuid();

            // Save task to repository here
            _tasks.Add(newTask);


            return this.Created<Models.TaskItem>("api/task/" + newTask.TaskID, newTask);


        }


        [Route("{id}")]
        public async Task<IHttpActionResult> Get(Guid id) {

            var task = _tasks.FirstOrDefault(t => t.TaskID == id);

            return this.Ok(task);


        }

    }
}
