using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShovelBoost : MonoBehaviour
{
    private BaseBlocks _baseBlocks;

    void Awake() 
    {
        _baseBlocks = FindObjectOfType<BaseBlocks>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.attachedRigidbody)
        {
            if(other.attachedRigidbody.GetComponent<PlayerHealth>())
            {
                _baseBlocks.GetConcreteBlock();
                Destroy(gameObject);
            }
        }
    }
}
