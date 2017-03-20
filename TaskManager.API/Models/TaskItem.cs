using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskManager.API.Models {
    public class TaskItem {

        public Guid TaskID { get; private set; }
        public string Name { get; set; }



        public TaskItem() {

            TaskID = Guid.NewGuid();


        }
    }
}