using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using ToDoList.Services.TaskServices;

namespace ToDoList.Controllers
{
    [ApiController]
    [Route("task/")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskInterface taskInterface;

        public TaskController(ITaskInterface taskInterface)
        {
            this.taskInterface = taskInterface;
        }
        

        [HttpPost]
        [Route("CreateTask")]
        public async Task<ActionResult<ServiceResponse<List<TaskModel>>>> CreateTask()
        {
            return Ok(await taskInterface.CreateTask());
        }

        [HttpDelete]
        [Route("DeleteTask")]
        public void DeleteTask()
        {
            
        }

        [HttpPut]
        [Route("UpdateTask")]
        public void UpdateTask()
        {

        }

        [HttpDelete]
        [Route("FinishTask")]

        public void FinishTask(){

        }

      

       
    }
}
