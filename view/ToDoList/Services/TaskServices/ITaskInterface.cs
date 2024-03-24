using ToDoList.Models;

namespace ToDoList.Services.TaskServices
{
    public interface ITaskInterface
    {
        Task<ServiceResponse<List<TaskModel>>> CreateTask(TaskModel task);

        Task<ServiceResponse<List<TaskModel>>> UpdateTask(TaskModel task);

        Task<ServiceResponse<List<TaskModel>>> DeleteTask (TaskModel task);

        Task <ServiceResponse<TaskModel>> GetTaskById (string taskId);
    }
}
