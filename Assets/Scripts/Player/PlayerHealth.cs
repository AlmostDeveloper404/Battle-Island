using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
   [SerializeField] private int _health = 2;

    public void TakeDamage(int damageValue)
    {
        _health -= damageValue;
        if(_health <= 0)
        {
            _health = 0;
            Destroy(gameObject);
        }
    }

    public void AddHealth()
    {
        if(_health < 3)
        {
            _health++;
        }
    }
}
