using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShovelBoost : MonoBehaviour
{
    private BaseBlocks _baseBlocks;
    private BoostSpawn _boostSpawn;

    void Awake() 
    {
        _baseBlocks = FindObjectOfType<BaseBlocks>();
        _boostSpawn = FindObjectOfType<BoostSpawn>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.attachedRigidbody)
        {
            if(other.attachedRigidbody.GetComponent<PlayerHealth>())
            {
                _baseBlocks.GetConcreteBlock();
                _boostSpawn.DeductBoostInGame();
                Destroy(transform.parent.gameObject);
            }
        }
    }
}
