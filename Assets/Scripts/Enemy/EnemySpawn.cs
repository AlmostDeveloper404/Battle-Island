using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    EnemyManager enemyManager;

    public IconsDisplayer iconsDisplayer;

    public List<Transform> enemiesToSpawn;

    private Transform[] spawnPositions;

    public float TimeToSpawn;
    [SerializeField]float _timer;

    private void Awake()
    {
        spawnPositions = new Transform[transform.childCount];
        for (int i = 0; i < spawnPositions.Length; i++)
        {
            spawnPositions[i] = transform.GetChild(i);
        }


        enemyManager = GetComponent<EnemyManager>();
    }

    private void Start()
    {

        _timer = TimeToSpawn;
        iconsDisplayer.UpdateIcon(enemiesToSpawn.Count);
        Spawn();
    }

    private void Update()
    {
        _timer -= Time.deltaTime;
        if (_timer<0)
        {
            _timer = TimeToSpawn;
            Spawn();
        }
    }
    public void Spawn()
    {
        if (enemiesToSpawn.Count==0)
        {
            iconsDisplayer.UpdateIcon(enemiesToSpawn.Count);
            enabled = false;
            return;
        }
        Transform newSpawnedTank = Instantiate(
        enemiesToSpawn[0],
        spawnPositions[Random.Range(0,spawnPositions.Length)].position,
        Quaternion.identity
                );
        RemoveFromList();
        iconsDisplayer.UpdateIcon(enemiesToSpawn.Count);
        enemyManager.AddToList(newSpawnedTank);
    }

    public void RemoveFromList()
    {
        enemiesToSpawn.RemoveAt(0);
    }

    
}