using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _health = 3;

    [SerializeField] private Vector3 _playerStartPosition;

    //[SerializeField] private Text _textHeath;

    private bool _invulnerable = false;

    void Start() 
    {
        _playerStartPosition = transform.position;
        //DisplayHealth();
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
            //DisplayHealth();
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
        //DisplayHealth();
    }

    //void DisplayHealth()
    //{
    //    _textHeath.text = $"{_health}";
    //}
}
