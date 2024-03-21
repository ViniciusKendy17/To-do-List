

using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using ToDoList.Services.TaskServices;

namespace ToDoList
{
    public class TaskModel 
    {
        [Key]
        public int id { get; set; }
        public  string title { get; set; }
        public string description { get; set; }

       

    }
}
