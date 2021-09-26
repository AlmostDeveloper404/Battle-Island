using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;

    [SerializeField] private Transform[] _spawnTransforms;

    [SerializeField] private float _spawnTimer;

    private float _timer;

    void Update()
    {
        _timer += Time.deltaTime;

        if(_timer >= _spawnTimer)
        {
            _timer = 0;

            Instantiate(_enemyPrefab, _spawnTransforms[Random.Range(0, 2)].position, _spawnTransforms[0].rotation, transform);
        }
    }
}
