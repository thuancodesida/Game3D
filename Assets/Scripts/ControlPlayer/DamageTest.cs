using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTest : MonoBehaviour
{
    public AttributesManager player_atm;
    public AttributesManager enemy_atm;
   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L)) {
                player_atm.DealDamage(enemy_atm.gameObject);
        }if(Input.GetKeyDown(KeyCode.K))
        {
            enemy_atm.DealDamage(player_atm.gameObject);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            DamagePopUp.current.CreatePopUp(new Vector3(529, 26, 548), Random.Range(0, 1000).ToString(),Color.yellow);
        }
    }
}
