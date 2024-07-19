using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInventory : MonoBehaviour
{
    public GameObject openPanel;
      
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Open()
    {
        openPanel.SetActive(true);
    }
    public void Close()
    {
        openPanel.SetActive(false);
    }
}
