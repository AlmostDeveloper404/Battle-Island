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

    [SerializeField]private List<Transform> enemiesSpawned=new List<Transform>();

    public float FreezingTime=3f;
    
    public void AddToList(Transform spawnedEnemy)
    {
        enemiesSpawned.Add(spawnedEnemy);
    }
    public void RemoveFromList(Transform destroyedEnemy)
    {
        enemiesSpawned.Remove(destroyedEnemy);
    }
    public void RemoveAll()
    {
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
