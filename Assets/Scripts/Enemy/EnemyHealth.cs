using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int _health = 1;
    [SerializeField] private GameObject _explosionPrefab, _destroyPrint;

    public AudioSource DeathSound;

    AudioManager audioManager;

    private void Start()
    {
        audioManager = AudioManager.instance;
    }
    public void TakeDamage(int damageValue)
    {
        _health -= damageValue;
        if(_health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        audioManager.DeathSound(DeathSound);
        Instantiate(_explosionPrefab, transform.position, transform.rotation);
        Instantiate(_destroyPrint, transform.position, _destroyPrint.transform.rotation);
        Destroy(gameObject);
    }
}
