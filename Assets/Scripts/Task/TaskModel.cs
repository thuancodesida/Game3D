using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Task
{
    public string taskName;
    public string taskDescription;
    public bool isCompleted;

    public Task(string taskName, string taskDescription)
    {
        this.taskName = taskName;
        this.taskDescription = taskDescription;
        this.isCompleted = false;
    }
    public void CompleteTask()
    {
        isCompleted = true;
    }
}