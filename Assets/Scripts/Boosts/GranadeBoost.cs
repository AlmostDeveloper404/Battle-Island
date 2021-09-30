using UnityEngine;

public class GranadeBoost : MonoBehaviour
{
    EnemyManager enemyManager;

    private void Start()
    {
        enemyManager = EnemyManager.instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Yep");
        if (other.attachedRigidbody)
        {
            if (other.attachedRigidbody.GetComponent<PlayerHealth>())
            {
                enemyManager.RemoveAll();
                Destroy(gameObject);
            }
        }
    }
}
