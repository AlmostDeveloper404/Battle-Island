using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
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
            PlayerMovement playerMovement = other.attachedRigidbody.GetComponent<PlayerMovement>();

            if(playerMovement)
            {
                playerMovement.IncreaseSpeed();
                _boostSpawn.DeductBoostInGame();
                Destroy(transform.parent.gameObject);
            }
        }
    }
}
