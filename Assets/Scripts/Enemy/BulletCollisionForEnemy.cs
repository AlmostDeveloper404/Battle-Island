using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollisionForEnemy : MonoBehaviour
{
    public int Damage;

    
    private void OnTriggerEnter(Collider other)
    {
        PlayerHealth playerHealth = other.GetComponentInParent<PlayerHealth>();
        
        if (playerHealth)
        {
            playerHealth.TakeDamage(Damage);
            DestroyBullet();
        }
        DestroyBullet();
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
