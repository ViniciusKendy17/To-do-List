using ToDoList.Models;

namespace ToDoList.Services.TaskServices
{
    public interface ITaskInterface
    {
        Task<ServiceResponse<List<TaskModel>>> CreateTask(TaskModel task);

        Task<ServiceResponse<List<TaskModel>>> UpdateTask(TaskModel task);

        Task<ServiceResponse<List<TaskModel>>> DeleteTask (int taskId);

       Task<ServiceResponse<List<TaskModel>>> FinishTask (int taskId);
    }
}
