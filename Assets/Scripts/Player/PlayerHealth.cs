using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _health = 3;

    [SerializeField] private Vector3 _playerStartPosition;

    [SerializeField] private Displayer _displayer;

    private bool _invulnerable = false;

    void Start() 
    {
        _playerStartPosition = transform.position;
    }

    public void TakeDamage()
    {
        if(!_invulnerable)
        {
            if(_health > 1)
            {
                transform.position = _playerStartPosition;
            }
            else
            {
                Destroy(gameObject);
            }
            _health--;
            _displayer.DisplayHealth();
            StartInvulnerable(3);
        }
    }

    public void StartInvulnerable(float time)
    {
        _invulnerable = true;
        Invoke("StopInvulnerable", time);
    }

    void StopInvulnerable()
    {
        _invulnerable = false;
    }

    public void AddHealth()
    {
        _health++;
        _displayer.DisplayHealth();
    }

    public int GetHealth()
    {
        return _health;
    }
}
