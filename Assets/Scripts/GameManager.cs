using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private EnemySpawn _enemySpawn;

    private List<GameObject> _enemys = new List<GameObject>();

    public void StopingTimeEnemys()
    {
       _enemys = _enemySpawn.GetEnemys();

       foreach(GameObject enemy in _enemySpawn.GetEnemys())
       {
           enemy.GetComponent<EnemyMoving>().enabled = false;
           enemy.GetComponent<EnemyShooting>().enabled = false;
           enemy.GetComponent<Rigidbody>().velocity = Vector3.zero;
       }

       _enemySpawn.enabled = false;
    }

    public void ResumeTimeEnemysInInvoke()
    {
        Invoke("ResumeTimeEnemys", 5);
    }

    void ResumeTimeEnemys()
    {
        foreach(GameObject enemy in _enemySpawn.GetEnemys())
        {
            enemy.GetComponent<EnemyMoving>().enabled = true;
            enemy.GetComponent<EnemyShooting>().enabled = true;
        }

        _enemySpawn.enabled = true;
    }
}
