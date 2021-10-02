using UnityEngine;

public class BulletCollisionForEnemy : MonoBehaviour
{

    SphereCollider sphereCollider;

    [SerializeField] private GameObject _effectPrefabe;

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
        Instantiate(_effectPrefabe, transform.position, _effectPrefabe.transform.rotation);
        Destroy(gameObject);
    }
}
