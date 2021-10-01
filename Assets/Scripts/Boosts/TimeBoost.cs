using UnityEngine;

public class TimeBoost : MonoBehaviour
{
    EnemyManager enemyManager;
    AudioManager audioManager;

    public AudioSource TimeSound;

    private void Start()
    {
        audioManager = AudioManager.instance;
        enemyManager = EnemyManager.instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.attachedRigidbody)
        {
            if(other.attachedRigidbody.GetComponent<PlayerHealth>())
            {
                audioManager.PlaySound(TimeSound);
                enemyManager.StopEnemyTime();
                Destroy(gameObject);
            }
        }
    }
}
