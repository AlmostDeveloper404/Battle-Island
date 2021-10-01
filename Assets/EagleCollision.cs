using UnityEngine;

public class EagleCollision : MonoBehaviour
{
    GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<BulletTrigger>())
        {
            gameManager.Lose();
        }
    }
}
