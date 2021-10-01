using UnityEngine;

public class InvulnerableBoost : MonoBehaviour
{
    AudioManager audioManager;
    public AudioSource Invalnerable;

    public float invulnerableTime;

    private void Start()
    {
        audioManager = AudioManager.instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.attachedRigidbody)
        {
            PlayerHealth playerHealth = other.attachedRigidbody.GetComponent<PlayerHealth>();
            if(playerHealth)
            {
                audioManager.PlaySound(Invalnerable);
                playerHealth.StartInvulnerable(invulnerableTime);
                Destroy(gameObject);
            }
        }
    }
}
