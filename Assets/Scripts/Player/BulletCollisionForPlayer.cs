using UnityEngine;

public class BulletCollisionForPlayer : MonoBehaviour
{
    public int Damage;
    EnemyManager enemyManager;
    SphereCollider sphereCollider;

    private void Awake()
    {
        sphereCollider = GetComponentInChildren<SphereCollider>();
    }
    private void Start()
    {
        enemyManager = EnemyManager.instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        sphereCollider.enabled = false;
        EnemyHealth enemyHealth = other.GetComponentInParent<EnemyHealth>();
        
        if (enemyHealth)
        {
            enemyManager.RemoveFromList(enemyHealth.transform);
            enemyHealth.TakeDamage(Damage);
        }
        DestroyBullet();
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
