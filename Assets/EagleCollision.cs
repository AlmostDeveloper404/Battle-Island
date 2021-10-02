using UnityEngine;

public class EagleCollision : MonoBehaviour
{
    GameManager gameManager;
    public AudioSource LastExplosion;

    private void Start()
    {
        gameManager = GameManager.instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<BulletTrigger>())
        {
            LastExplosion.Play();
            gameManager.Lose();
        }
    }
}
