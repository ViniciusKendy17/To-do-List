using ToDoList.Models;

namespace ToDoList.Services.TaskServices
{
    public class TaskService : ITaskInterface
    {
        private readonly DBContext Context;

        public TaskService(DBContext _context)
        {
            this.Context = _context;
        }

        public Task<ServiceResponse<List<TaskModel>>> CreateTask(TaskModel task)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<TaskModel>>> DeleteTask(TaskModel task)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<TaskModel>> GetTaskById(string taskId)
        {

            throw new NotImplementedException();

        }

        public Task<ServiceResponse<List<TaskModel>>> UpdateTask(TaskModel task)
        {
            throw new NotImplementedException();
        }
    }
}
