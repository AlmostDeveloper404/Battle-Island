using UnityEngine;

public class InvulnerableBoost : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.attachedRigidbody)
        {
            PlayerHealth playerHealth = other.attachedRigidbody.GetComponent<PlayerHealth>();
            if(playerHealth)
            {
                playerHealth.StartInvulnerable(5);
                Destroy(gameObject);
            }
        }
    }
}
