using UnityEngine;

public class HealthBoost : MonoBehaviour
{
    AudioManager audioManager;
    private void Start()
    {
        audioManager = AudioManager.instance;
    }
    public AudioSource HealthPick;
    private void OnTriggerEnter(Collider other)
    {
        if(other.attachedRigidbody)
        {
            PlayerHealth playerHealth = other.attachedRigidbody.GetComponent<PlayerHealth>();

            if(playerHealth)
            {
                audioManager.PlaySound(HealthPick);
                playerHealth.AddHealth();
                Destroy(gameObject);
            }
        }
    }
}
