using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public static TaskManager instance;
    public List<Task> tasks;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        tasks = new List<Task>();
    }
    public void AddTask(string taskName,string description)
    {
        Task newTask = new Task(taskName,description);
        tasks.Add(newTask);
        
    }
    public void CompleteTask(string taskName)
    {
        Task task = tasks.Find(t=>t.taskName == taskName);
        if(task != null)
        {
            task.CompleteTask();
        }

    }
    public List<Task> GetTasks()
    {
        return tasks;
    }
}
