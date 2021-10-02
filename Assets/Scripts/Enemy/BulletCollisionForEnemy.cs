using UnityEngine;

public class BulletCollisionForEnemy : MonoBehaviour
{

    SphereCollider sphereCollider;

    private void Start()
    {
        sphereCollider = GetComponentInChildren<SphereCollider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Yep");
        sphereCollider.enabled = false;
        PlayerHealth playerHealth = other.GetComponentInParent<PlayerHealth>();
        
        if (playerHealth)
        {
            playerHealth.TakeDamage();
        }
        DestroyBullet();
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
