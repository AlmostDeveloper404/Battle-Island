using UnityEngine;

public class GranadeBoost : MonoBehaviour
{
    EnemyManager enemyManager;
    AudioManager audioManager;
    public AudioSource GranadePicked;

    private void Start()
    {
        audioManager = AudioManager.instance;
        enemyManager = EnemyManager.instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Yep");
        if (other.attachedRigidbody)
        {
            if (other.attachedRigidbody.GetComponent<PlayerHealth>())
            {
                PickUp();              
            }
        }
    }

    void PickUp()
    {
        audioManager.PlaySound(GranadePicked);
        enemyManager.AllDie();
        Destroy(gameObject);
        
    }
}
