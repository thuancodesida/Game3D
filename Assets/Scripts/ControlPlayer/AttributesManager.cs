using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttributesManager : MonoBehaviour
{
    public int health;
    public int attack;
    public float critDamage = 1.5f;
    public float critChance = 0.2f;
    public GameObject Panel;
    
    
  
    public void TakeDamage(int amouth)
    {
        health -= amouth;
        Vector3 rand = new Vector3(Random.Range(0, 0.25f),
                                    Random.Range(0, 0.25f),
                                 Random.Range(0, 0.25f));

        DamagePopUp.current.CreatePopUp(transform.position +rand,amouth.ToString(),Color.red);

        if (gameObject.CompareTag("Enemy"))
        {
            Slider slider = gameObject.transform
                .GetChild(0).transform
                .GetChild(0).transform
                .GetComponent<Slider>();
            slider.value = health;


            if (health <= 0)
            {

                //Animator animator = GetComponent<Animator>(); 
                EnemyDie();
                //animator.SetBool("isDead", true);
               
            }
        }
        if (gameObject.CompareTag("Player"))
        {
            Slider slider = gameObject.transform
                .GetChild(0).transform
                .GetChild(0).transform.GetComponent<Slider>();
            slider.value = health;

            if(health <= 0)
            {
                PlayerDeath();
                Panel.SetActive(true);

            }
        }
    }
  
    public void DealDamage(GameObject target)
    {
        var atm = target.GetComponent<AttributesManager>();
        if (atm != null)
        {
            float totalDamaged = attack;
            if(Random.Range(0f,1f)<critChance)
            {
                totalDamaged *= critDamage;
            }
            atm.TakeDamage((int)totalDamaged);
        }

    }   
    public void EnemyDie()
    {
        Debug.Log("Enemy Die");
        Animator animator = GetComponent<Animator>();
         animator.SetBool("isDead", true);
        // GameObject enemyObject = GameObject.Find("EnemyBig");
        Destroy(gameObject, 2f);
    }
    public void PlayerDeath()
    {
        Debug.Log("Player Die");
        Animator animator = GetComponent<Animator>();
        animator.SetBool("isDead", true);
        Destroy(gameObject, 2f);
        
    }    
}
