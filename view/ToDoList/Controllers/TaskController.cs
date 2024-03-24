using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using ToDoList.Services.TaskServices;

namespace ToDoList.Controllers
{
    [ApiController]
    [Route("task/")]
    public class TaskController : ControllerBase
    {
        

        [HttpPost]
        [Route("CreateTask")]
        public string Retornarpalavra()
        {
            return "Hello man";
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

      

       
    }
}
