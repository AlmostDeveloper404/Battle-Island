using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int _health = 1;

    [SerializeField] private EnemySpawn _enemySpawn;

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
        _enemySpawn.RemoveFromEnemys(gameObject);
        Destroy(gameObject);
    }
}