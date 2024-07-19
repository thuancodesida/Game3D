using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public string Description { get; set; }
    public bool Completed { get; set; }
    public int CurrentAmount { get; set; }
    public int RequireAmount { get; set; }

    public virtual void Init()
    {

    }
    
    public void Evaluate()
    {
        if(CurrentAmount >= RequireAmount)
        {
            Complete();
        }
    }

    public void Complete()
    {
        Completed = true;
    }
}
