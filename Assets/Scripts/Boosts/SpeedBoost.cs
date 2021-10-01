using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public AudioSource SpeedBoostSound;
    AudioManager audioManager;
    private void Start()
    {
        audioManager = AudioManager.instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.attachedRigidbody)
        {
            PlayerMovement playerMovement = other.attachedRigidbody.GetComponent<PlayerMovement>();

            if(playerMovement)
            {
                audioManager.PlaySound(SpeedBoostSound);
                playerMovement.IncreaseSpeed();
                Destroy(gameObject);
            }
        }
    }
}
