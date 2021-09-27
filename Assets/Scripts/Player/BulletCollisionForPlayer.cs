using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollisionForPlayer : MonoBehaviour
{
    public int Damage;

    
    private void OnTriggerEnter(Collider other)
    {
        
        EnemyHealth enemyHealth = other.GetComponentInParent<EnemyHealth>();
        
        if (enemyHealth)
        {
            enemyHealth.TakeDamage(Damage);
            DestroyBullet();
        }
        DestroyBullet();
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
