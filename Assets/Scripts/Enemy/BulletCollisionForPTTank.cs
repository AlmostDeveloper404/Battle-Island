using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollisionForPTTank : MonoBehaviour
{
    SphereCollider sphereCollider;

    [SerializeField] private GameObject _effectPrefabe;

    private int _bulletHealth = 3;

    private void Start()
    {
        sphereCollider = GetComponentInChildren<SphereCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _bulletHealth--;
        PlayerHealth playerHealth = other.GetComponentInParent<PlayerHealth>();
        
        if (playerHealth)
        {
            playerHealth.TakeDamage();
        }

        if(_bulletHealth <= 0)
        {
            sphereCollider.enabled = false;
            DestroyBullet();
        }
    }

    void DestroyBullet()
    {
        Instantiate(_effectPrefabe, transform.position, _effectPrefabe.transform.rotation);
        Destroy(gameObject);
    }
}
