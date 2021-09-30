using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _health = 3;

    [SerializeField] private Vector3 _playerStartPosition;

    [SerializeField] private GameObject _shield;

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
            StartInvulnerable(3);
        }
    }

    public void StartInvulnerable(float time)
    {
        _shield.SetActive(true);
        _invulnerable = true;
        Invoke("StopInvulnerable", time);
    }

    void StopInvulnerable()
    {
        _shield.SetActive(false);
        _invulnerable = false;
    }

    public void AddHealth()
    {
        _health++;
    }

    public int GetHealth()
    {
        return _health;
    }
}
