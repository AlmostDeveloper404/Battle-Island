using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int _health = 1;
    [SerializeField] private GameObject _explosionPrefab, _destroyPrint;
    [SerializeField] private GameObject _shield;

    public AudioSource DeathSound;

    AudioManager audioManager;

    private bool _invulnerable = false;

    private void Start()
    {
        audioManager = AudioManager.instance;
        StartInvulnerable(3);
    }
    public void TakeDamage(int damageValue)
    {
        if(!_invulnerable)
        {
            _health -= damageValue;
            if(_health <= 0)
            {
                Die();
            }
        }
    }

    public void Die()
    {
        DeathSound.transform.parent = null;
        DeathSound.Play();

        Instantiate(_explosionPrefab, transform.position, transform.rotation);
        Instantiate(_destroyPrint, transform.position, _destroyPrint.transform.rotation);
        Destroy(gameObject,.001f);
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

    
}
