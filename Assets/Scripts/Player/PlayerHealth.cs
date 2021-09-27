using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _health = 3;

    [SerializeField] private Vector3 _playerStartPosition;

    private bool _invulnerable = false;

    void Start() 
    {
        _playerStartPosition = transform.position;
    }

    public void TakeDamage()
    {
        if(!_invulnerable)
        {
            if(_health > 0)
            {
                transform.position = _playerStartPosition;
                _health--;
            }
            else
            {
                Destroy(gameObject);
            }
            _invulnerable = true;
            Invoke("StopInvulnerable", 3f);
        }
    }

    void StopInvulnerable()
    {
        _invulnerable = false;
    }

    public void AddHealth()
    {
        _health++;
    }
}
