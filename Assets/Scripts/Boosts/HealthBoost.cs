using UnityEngine;

public class HealthBoost : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.attachedRigidbody)
        {
            PlayerHealth playerHealth = other.attachedRigidbody.GetComponent<PlayerHealth>();

            if(playerHealth)
            {
                playerHealth.AddHealth();
                Destroy(gameObject);
            }
        }
    }
}
