using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBoost : MonoBehaviour
{
    private GameManager _gameManager;

    void Awake()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.attachedRigidbody)
        {
            if(other.attachedRigidbody.GetComponent<PlayerHealth>())
            {
                _gameManager.StopingTimeEnemys();
                _gameManager.ResumeTimeEnemysInInvoke();
                Destroy(gameObject);
            }
        }
    }
}
