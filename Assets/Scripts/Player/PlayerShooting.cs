using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private float _bulletSpeed, _shotPeriod;

    [SerializeField] private GameObject _bulletPrefab;

    [SerializeField] private Transform _firePoint;

    private float _timer; 

    void Update()
    {
        _timer += Time.deltaTime;  

        if(Input.GetKey(KeyCode.Space) && _timer > _shotPeriod)
        {
            _timer = 0f;
            GameObject newBullet = Instantiate(_bulletPrefab, _firePoint.position, _firePoint.rotation);
            newBullet.GetComponent<Rigidbody>().velocity = transform.forward * _bulletSpeed;
        }
    }
}
