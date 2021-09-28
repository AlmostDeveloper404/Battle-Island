using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvulnerableBoost : MonoBehaviour
{
    private BoostSpawn _boostSpawn;

    void Awake()
    {
        _boostSpawn = FindObjectOfType<BoostSpawn>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.attachedRigidbody)
        {
            PlayerHealth playerHealth = other.attachedRigidbody.GetComponent<PlayerHealth>();
            if(playerHealth)
            {
                playerHealth.StartInvulnerable(5);
                _boostSpawn.DeductBoostInGame();
                Destroy(transform.parent.gameObject);
            }
        }
    }
}
