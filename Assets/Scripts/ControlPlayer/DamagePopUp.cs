using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine;


public class DamagePopUp : MonoBehaviour
{
    public static DamagePopUp current;
    [SerializeField] public GameObject prefabs;
    // Start is called before the first frame update
    private void Awake()
    {
        current = this;
      
    }
  
    public void CreatePopUp(Vector3 position,string text,Color color)
    {
        var popup = Instantiate(prefabs,position,Quaternion.identity);
        TextMeshProUGUI temp = popup.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        temp.text = text;
        temp.color = color;

        Destroy(popup,2f);
        Destroy(temp, 2f);
    }
}
