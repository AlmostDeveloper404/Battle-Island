using UnityEngine;

public class InvulnerableBoost : MonoBehaviour
{
    AudioManager audioManager;
    public AudioSource Invalnerable;

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
                playerHealth.StartInvulnerable(5);
                Destroy(gameObject);
            }
        }
    }
}
