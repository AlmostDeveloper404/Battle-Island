using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       DestroyBullet();
    }

    public void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
