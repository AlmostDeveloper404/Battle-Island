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
        sphereCollider.enabled = false;
        PlayerHealth playerHealth = other.GetComponentInParent<PlayerHealth>();
        Vector3 point= other.ClosestPoint(transform.position);
        if (playerHealth)
        {
            playerHealth.TakeDamage();
        }
        DestroyBullet(point);
    }

    void DestroyBullet(Vector3 point)
    {
        Instantiate(_effectPrefabe, point, _effectPrefabe.transform.rotation);
        Destroy(gameObject);
    }
}
