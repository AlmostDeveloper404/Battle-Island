using UnityEngine;

public class BulletCollisionForPlayer : MonoBehaviour
{
    public int Damage;
    EnemyManager enemyManager;
    SphereCollider sphereCollider;
    [SerializeField] private GameObject _effectPrefabe;

    AudioManager audioManager;

    public AudioSource BulletCollisionSound;

    private void Awake()
    {
        sphereCollider = GetComponentInChildren<SphereCollider>();
    }
    private void Start()
    {
        audioManager = AudioManager.instance;
        enemyManager = EnemyManager.instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        sphereCollider.enabled = false;
        EnemyHealth enemyHealth = other.GetComponentInParent<EnemyHealth>();
        
        if (enemyHealth)
        {
            enemyManager.RemoveFromList(enemyHealth.transform);
            enemyHealth.TakeDamage(Damage);
        }
        DestroyBullet();
    }

    void DestroyBullet()
    {
        audioManager.PlaySound(BulletCollisionSound);
        Instantiate(_effectPrefabe, transform.position, _effectPrefabe.transform.rotation);
        Destroy(gameObject);
    }
}
