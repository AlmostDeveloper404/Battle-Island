using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollisionForEnemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerHealth playerHealth = other.GetComponentInParent<PlayerHealth>();
        
        if (playerHealth)
        {
            playerHealth.TakeDamage();
            DestroyBullet();
        }
        DestroyBullet();
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
