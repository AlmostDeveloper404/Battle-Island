using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranadeBoost : MonoBehaviour
{
    private EnemySpawn _enemySpawn;
    private BoostSpawn _boostSpawn;

    void Awake() 
    {
        _enemySpawn = FindObjectOfType<EnemySpawn>();
        _boostSpawn = FindObjectOfType<BoostSpawn>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.attachedRigidbody)
        {
            if(other.attachedRigidbody.GetComponent<PlayerHealth>())
            {
                foreach(GameObject enemy in _enemySpawn.GetEnemys())
                {
                    Destroy(enemy);
                }
                _boostSpawn.DeductBoostInGame();
                Destroy(transform.parent.gameObject);
            }
        }
    }
}
