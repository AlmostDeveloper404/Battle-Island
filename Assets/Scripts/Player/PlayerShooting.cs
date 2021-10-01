using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private float _bulletSpeed, _shotPeriod;

    [SerializeField] private GameObject _bulletPrefab;

    [SerializeField] private Transform _firePoint;
    public GameObject ShootEffect;

    private float _timer; 

    void Update()
    {
        _timer += Time.deltaTime;  

        if(Input.GetKey(KeyCode.Space) && _timer > _shotPeriod)
        {
            Shoot(); 
        }
    }

    void Shoot()
    {
        _timer = 0f;
        GameObject shootEffect = Instantiate(ShootEffect,_firePoint.position,_firePoint.rotation);
        Destroy(shootEffect,2f);
        GameObject newBullet = Instantiate(_bulletPrefab, _firePoint.position, _firePoint.rotation);
        newBullet.GetComponent<Rigidbody>().velocity = transform.forward * _bulletSpeed;
    }
}
