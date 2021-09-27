using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;

    [SerializeField] private Transform[] _spawnTransforms;

    [SerializeField] private float _spawnTimer, _maxEnemys;

    [SerializeField] private List<GameObject> _enemys = new List<GameObject>();

    private float _timer;

    void Start()
    {
        SpawnEnemy();
    }

    void Update()
    {
        if(_enemys.Count < _maxEnemys)
        {
            _timer += Time.deltaTime;

            if(_timer >= _spawnTimer)
            {
                _timer = 0;

                SpawnEnemy();
            }
        }
    }

    void SpawnEnemy()
    {
        GameObject newEnemy = Instantiate(_enemyPrefab, _spawnTransforms[Random.Range(0, 3)].position, _spawnTransforms[0].rotation, transform);
        _enemys.Add(newEnemy);
    }

    public void RemoveFromEnemys(GameObject enemy)
    {
        _enemys.Remove(enemy);
    }

    public List<GameObject> GetEnemys()
    {
        return _enemys;
    }
}