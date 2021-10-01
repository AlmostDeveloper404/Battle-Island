using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    #region Singleton

    public static EnemyManager instance;

    private void Awake()
    {
        if (instance!=null)
        {
            Debug.LogWarning("More than one EnemyManager!");
            return;
        }
        instance = this;
    }

    #endregion
    GameManager gameManager;
    EnemySpawn enemySpawn;
    [SerializeField]private List<Transform> enemiesSpawned=new List<Transform>();

    public float FreezingTime=3f;

    private void Start()
    {
        enemySpawn = GetComponent<EnemySpawn>();
        gameManager = GameManager.instance;
    }
    public void AddToList(Transform spawnedEnemy)
    {
        enemiesSpawned.Add(spawnedEnemy);
    }
    public void RemoveFromList(Transform destroyedEnemy)
    {
        enemiesSpawned.Remove(destroyedEnemy);
        if (enemiesSpawned.Count==0 && enemySpawn.enemiesToSpawn.Count==0)
        {
            gameManager.Win();
        }
    }
    public void AllDie()
    {
        for (int i = 0; i < enemiesSpawned.Count; i++)
        {
            enemiesSpawned[i].GetComponent<EnemyHealth>().TakeDamage(100);
        }
        enemiesSpawned.Clear();
    }

    public void StopEnemyTime()
    {
        for (int i = 0; i < enemiesSpawned.Count; i++)
        {
            enemiesSpawned[i].GetComponent<EnemyMoving>().FreezeEnemy();
        }
        Invoke("ResumeEnemyTime",FreezingTime);
    }

    public void ResumeEnemyTime()
    {
        for (int i = 0; i < enemiesSpawned.Count; i++)
        {
            enemiesSpawned[i].GetComponent<EnemyMoving>().Unfreeze();
        }
    }
    
}
