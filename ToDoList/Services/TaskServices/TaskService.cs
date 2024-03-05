using Microsoft.AspNetCore.Http.HttpResults;
using ToDoList.Models;


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
            
            if (task == null) 
            {
                Console.WriteLine("Something went wrong");
            } 

            try
            {
                _context.Add(task);
                await _context.SaveChangesAsync();

                serviceresponse.data = _context.Tasks.ToList();
                
                
            }
            catch(Exception ex)
            {
                serviceresponse.message = "Something wrong by trying to add a new task";
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
