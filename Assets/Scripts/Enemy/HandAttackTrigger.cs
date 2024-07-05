using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTrisger : MonoBehaviour
{
    public AttributesManager atm;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            other.GetComponent<AttributesManager>().TakeDamage(atm.attack);
    }
}
