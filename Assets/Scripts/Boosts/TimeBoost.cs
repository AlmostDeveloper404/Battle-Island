using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBoost : MonoBehaviour
{
    private GameManager _gameManager;
    private BoostSpawn _boostSpawn;

    void Awake()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _boostSpawn = FindObjectOfType<BoostSpawn>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.attachedRigidbody)
        {
            if(other.attachedRigidbody.GetComponent<PlayerHealth>())
            {
                _gameManager.StopingTimeEnemys();
                _gameManager.ResumeTimeEnemysInInvoke();
                _boostSpawn.DeductBoostInGame();
                Destroy(gameObject);
            }
        }
    }
}
