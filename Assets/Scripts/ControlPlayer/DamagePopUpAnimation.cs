using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamagePopUpAnimation : MonoBehaviour
{
    public AnimationCurve curve;
    private TextMeshProUGUI tmp;
    float time = 0;
       
    private void Awake()
    {
        tmp = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
    }
   
    // Update is called once per frame
    void Update()
    {
        tmp.color = new Color(tmp.color.r,tmp.color.g,tmp.color.b
            
            ,curve.Evaluate(time));
        time += Time.deltaTime;
    }
}
