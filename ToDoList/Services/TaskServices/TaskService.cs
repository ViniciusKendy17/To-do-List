using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using ToDoList.Models;
using Xunit.Sdk;


namespace ToDoList.Services.TaskServices
{
    public class TaskService : ITaskInterface
    {
        private readonly DBContext _context;

        public TaskService(DBContext _context)
        {
            this._context = _context;
        }

        public async Task<ServiceResponse<List<TaskModel>>> CreateTask(TaskModel task)
        {
            ServiceResponse<List<TaskModel>> serviceresponse = new ServiceResponse<List<TaskModel>>();
            
           try{
           
                _context.Add(task);
                await _context.SaveChangesAsync();

                serviceresponse.data = await _context.tarefa.ToListAsync();         
           }
           catch(NullException ex)
           {
                serviceresponse.success = false;
                serviceresponse.message = $"Null value not allowed {ex.Message}"; 
           }

           return serviceresponse;
  
        }

        public Task<ServiceResponse<List<TaskModel>>> DeleteTask(int taskId)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<TaskModel>>> FinishTask(int taskId)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<TaskModel>>> UpdateTask(TaskModel task)
        {
            throw new NotImplementedException();
        }
    }
}
