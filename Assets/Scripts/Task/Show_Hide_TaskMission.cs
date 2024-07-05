using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_Hide_TaskMission : MonoBehaviour
{
    public GameObject Canvas;
    // Start is called before the first frame update
    void Start()
    {
        Show();
    }

   public void Hide()
    {
        Canvas.SetActive(false);
    }
   public  void Show()
    {
        Canvas.SetActive(true);
    }
}
