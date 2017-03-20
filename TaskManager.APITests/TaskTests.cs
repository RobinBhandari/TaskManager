using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TaskManager.API;
using Xunit;
using TaskManager.API.Models;


namespace TaskManager.APITests {
    public class TaskTests {

        [Fact]
        public async Task<Guid> Task_Create() {

            using (var serverAndClient = new HttpServerAndClient<Startup>()) {

                var newTask = new { Name = "Task1" };



                var response = await serverAndClient.Client.PostAsJsonAsync("api/task", newTask);



                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsAsync<TaskItem>();


                Assert.Equal(Convert.ToInt32(System.Net.HttpStatusCode.Created), Convert.ToInt32(response.StatusCode));
                Assert.NotEqual(Guid.Empty, content.TaskID);

                return content.TaskID;


            }


        }

        [Fact]
        public async Task Task_Get() {

            var newID = await Task_Create();

            using (var serverAndClient = new HttpServerAndClient<Startup>()) {
                var response = await serverAndClient.Client.GetAsync("api/task/" + newID);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsAsync<TaskItem>();

                Assert.Equal(newID, content.TaskID);

            }
        }
     
    }


}
