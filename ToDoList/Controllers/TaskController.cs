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
        
        //Add a task in the database
        [HttpPost]
        [Route("add-task")]
        
        public async Task<ActionResult<ServiceResponse<List<TaskModel>>>> CreateTask(TaskModel task)
        {

            return Ok(await taskInterface.CreateTask(task));
        }

        //Delete a task specified by a id
        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<ActionResult<ServiceResponse<List<TaskModel>>>> DeleteTask(int id)
        {
            ServiceResponse<List<TaskModel>> serviceResponse = await taskInterface.DeleteTask(id);

            return Ok(serviceResponse);
        }

        //Update a task
        [HttpPut]
        [Route("UpdateTask")]
        public async Task<ActionResult<ServiceResponse<List<TaskModel>>>>  UpdateTask(TaskModel task)
        {
            ServiceResponse<List<TaskModel>> serviceResponse = await taskInterface.UpdateTask(task);

            return Ok(serviceResponse);

        }

        //Same as the DeleteTask, but instead of deleting, it is "finishing" it 
        [HttpDelete]
        [Route("FinishTask/{id}")]

        public async Task<ActionResult<ServiceResponse<List<TaskModel>>>> FinishTask(int id)
        {
             ServiceResponse<List<TaskModel>> serviceResponse = await taskInterface.DeleteTask(id);

            return Ok(serviceResponse);
        }

      

       
    }
}
