using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.attachedRigidbody)
        {
            PlayerMovement playerMovement = other.attachedRigidbody.GetComponent<PlayerMovement>();

            if(playerMovement)
            {
                playerMovement.IncreaseSpeed();
                Destroy(gameObject);
            }
        }
    }
}
