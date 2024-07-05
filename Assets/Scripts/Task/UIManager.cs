using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject taskUIPrefab;
    public Transform taskListParent;
    void Start()
    {
        UpdateTaskList();
    }

    // Update is called once per frame
    void UpdateTaskList()
    {
        foreach(Transform child in taskListParent)
        {
            Destroy(child.gameObject);
        }
        List<Task> tasks = TaskManager.instance.GetTasks();
        foreach(Task task in tasks)
        {
            GameObject taskUIInstance = Instantiate(taskUIPrefab, taskListParent);
            TextMeshProUGUI[] texts = taskUIInstance.GetComponentsInChildren<TextMeshProUGUI>();
            texts[0].text = task.taskName;
            texts[1].text = task.taskDescription;
            texts[2].text = task.isCompleted ? "Complete" : "In Progress";
        }
    }
}
