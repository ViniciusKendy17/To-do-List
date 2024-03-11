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
           catch(Exception ex)
           {
                serviceresponse.success = false;
                serviceresponse.message = ex.Message; 
           }

           return serviceresponse;
  
        }

        public async Task<ServiceResponse<List<TaskModel>>> DeleteTask(int taskId)
        {
              ServiceResponse<List<TaskModel>> serviceresponse = new ServiceResponse<List<TaskModel>>();

              try
              {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                TaskModel task = _context.tarefa.FirstOrDefault(x => x.id == taskId);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                
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
              catch(Exception ex)
              {
                    serviceresponse.message = ex.Message;
                    serviceresponse.success = false;
              }
                    return serviceresponse;
        }

        public async Task<ServiceResponse<List<TaskModel>>> FinishTask(int taskId)
        {
             ServiceResponse<List<TaskModel>> serviceresponse = new ServiceResponse<List<TaskModel>>();

              try
              {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                TaskModel task = _context.tarefa.FirstOrDefault(x => x.id == taskId);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                
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
              catch(Exception ex )
              {
                    serviceresponse.message = ex.Message ;
                    serviceresponse.success = false;
              }
                        return serviceresponse;
        }

        public async Task<ServiceResponse<List<TaskModel>>> UpdateTask(TaskModel taskup)
        {
            ServiceResponse<List<TaskModel>> serviceresponse = new ServiceResponse<List<TaskModel>>(); 

            try
            {

                TaskModel task = _context.tarefa.AsNoTracking().FirstOrDefault(x => x.id == taskup.id);


                if(task == null)
                {
                     serviceresponse.data = null;  
                    serviceresponse.message = "This task does not exist.";
                    serviceresponse.success = false;      
            
                }

                 _context.tarefa.Update(taskup);

                
                  await _context.SaveChangesAsync();

                serviceresponse.data =  _context.tarefa.ToList(); 

            }
            catch(Exception ex )
            {
                serviceresponse.message = ex.Message;
                serviceresponse.success = false;
            }

            return serviceresponse;

        }
    }
}
