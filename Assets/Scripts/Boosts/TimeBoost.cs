using UnityEngine;

public class TimeBoost : MonoBehaviour
{
    EnemyManager enemyManager;

    private void Start()
    {
        enemyManager = EnemyManager.instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.attachedRigidbody)
        {
            if(other.attachedRigidbody.GetComponent<PlayerHealth>())
            {
                enemyManager.StopEnemyTime();
                Destroy(gameObject);
            }
        }
    }
}
