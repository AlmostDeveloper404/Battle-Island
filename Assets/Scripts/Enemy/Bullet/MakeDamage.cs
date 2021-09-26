using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDamage : MonoBehaviour
{
    [SerializeField] private int _damageValue = 1;
    void OnTriggerEnter(Collider other)
    {
        if(other.attachedRigidbody)
        {
            PlayerHealth playerHealth = other.attachedRigidbody.GetComponent<PlayerHealth>();
            if(playerHealth)
            {
                playerHealth.TakeDamage(_damageValue);
            }
        }
    }
}
