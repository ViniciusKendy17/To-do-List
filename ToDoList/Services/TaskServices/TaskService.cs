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

        public async Task<ServiceResponse<List<TaskModel>>> DeleteTask(int taskId)
        {
              ServiceResponse<List<TaskModel>> serviceresponse = new ServiceResponse<List<TaskModel>>();

              try
              {
                TaskModel task = _context.tarefa.FirstOrDefault(x => x.id == taskId);
                
                if(task == null)
                {
                    serviceresponse.message = "This task does not exist.";
                    serviceresponse.success = false;
                    serviceresponse.data = null;

                    return serviceresponse;
                }

                    _context.tarefa.Remove(task);
                    await _context.SaveChangesAsync();

                    serviceresponse.data = await _context.tarefa.ToListAsync();          

              }
              catch(Exception)
              {
                    serviceresponse.message = "It wasn't possible to remove the task that you wanted to";
                    serviceresponse.success = false;
              }
                    return serviceresponse;
        }

        public async Task<ServiceResponse<List<TaskModel>>> FinishTask(int taskId)
        {
             ServiceResponse<List<TaskModel>> serviceresponse = new ServiceResponse<List<TaskModel>>();

              try
              {
                TaskModel task = _context.tarefa.FirstOrDefault(x => x.id == taskId);
                
                if(task == null)
                {
                    serviceresponse.message = "This task does not exist.";
                    serviceresponse.success = false;
                    serviceresponse.data = null;

                    return serviceresponse;
                }

                    _context.tarefa.Remove(task);
                    await _context.SaveChangesAsync();

                    serviceresponse.data = await _context.tarefa.ToListAsync();          

              }
              catch(Exception)
              {
                    serviceresponse.message = "It wasn't possible to finish the task that you wanted to";
                    serviceresponse.success = false;
              }
                        return serviceresponse;
        }

        public async Task<ServiceResponse<List<TaskModel>>> UpdateTask(TaskModel taskup)
        {
            ServiceResponse<List<TaskModel>> serviceResponse = new ServiceResponse<List<TaskModel>>(); 

            try
            {
                TaskModel task = _context.tarefa.FirstOrDefault(x => x.id == taskup.id);

                  if(task == null)
                {
                    serviceResponse.message = "This task does not exist.";
                    serviceResponse.success = false;
                    serviceResponse.data = null;             
                }
                
                _context.tarefa.Update(task);
                
                  await _context.SaveChangesAsync();

                serviceResponse.data =  _context.tarefa.ToList(); 

            }
            catch(Exception)
            {
                serviceResponse.message = "It wasn't possible to update the task that you wanted to";
                serviceResponse.success = false;
            }

            return serviceResponse;

        }
    }
}
