using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int _health = 1;
    [SerializeField] private GameObject _tank, _explosionPrefab, _destroyPrint;

    private EnemySpawn _enemySpawn;

    void Awake()
    {
        _enemySpawn = FindObjectOfType<EnemySpawn>();
    }

    public void TakeDamage(int damageValue)
    {
        _health -= damageValue;
        if(_health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(_explosionPrefab, transform.position, transform.rotation);
        Instantiate(_destroyPrint, transform.position, _destroyPrint.transform.rotation);
        Destroy(gameObject);
    }
    void OnDestroy()
    {
        _enemySpawn.RemoveFromEnemys(gameObject);
    }
}
