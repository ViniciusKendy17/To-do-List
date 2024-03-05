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
        
        public async Task<ActionResult<ServiceResponse<List<TaskModel>>>> CreateTask(TaskModel task)
        {

            return Ok(await taskInterface.CreateTask(task));
        }

        [HttpDelete]
        
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
