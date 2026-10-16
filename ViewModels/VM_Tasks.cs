using System;
using System.Collections.ObjectModel;
using System.Linq;
using TaskManager_Osennikov.Classes;
using TaskManager_Osennikov.Context;
using TaskManager_Osennikov.Models;

namespace TaskManager_Osennikov.ViewModels
{
    public class VM_Tasks : Notification
    {
        public TasksContext tasksContext = new TasksContext();
        public ObservableCollection<Tasks> Tasks { get; set; }

        public VM_Tasks()
        {
            var tasksList = tasksContext.Tasks.OrderBy(t => t.Done).ToList();
            Tasks = new ObservableCollection<Tasks>(tasksList);
        }

        public RelayCommand OnAddTask => new RelayCommand(obj =>
        {
            var newTask = new Tasks() { DateExecute = DateTime.Now };
            Tasks.Add(newTask);
            tasksContext.Tasks.Add(newTask);
            tasksContext.SaveChanges();
        });
    }
}