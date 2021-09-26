using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.attachedRigidbody)
        {
            if(other.attachedRigidbody.name == "Enemy(Clone)")
            {
                return;
            }
            else
            {
                DestroyBullet();
            }
        }
        else
        {
            DestroyBullet();
        }
    }

    public void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
