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
        [Route("add-task")]
        
        public async Task<ActionResult<ServiceResponse<List<TaskModel>>>> CreateTask(TaskModel task)
        {

            return Ok(await taskInterface.CreateTask(task));
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<ActionResult<ServiceResponse<List<TaskModel>>>> DeleteTask(int id)
        {
            ServiceResponse<List<TaskModel>> serviceResponse = await taskInterface.DeleteTask(id);

            return Ok(serviceResponse);
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
