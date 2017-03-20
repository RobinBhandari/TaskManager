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

namespace TaskManager.APITests {
    public class TaskTests {

        [Fact]
        public async Task Task_Create() {

            using (var serverAndClient = new HttpServerAndClient<Startup>()) {

                var newTask = new { Name = "Task1" };



                var response = await serverAndClient.Client.PostAsJsonAsync("api/task", newTask);

                response.EnsureSuccessStatusCode();

               


            }

        }
    }
}
