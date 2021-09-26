using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] _boostPrefabs;
    [SerializeField] private Transform[] _spawnPositions;

    [SerializeField] private float _spawnTimer;

    private float _timer;

    void Update()
    {
        _timer += Time.deltaTime;

        if(_timer >= _spawnTimer)
        {
            _timer = 0;

            Instantiate(_boostPrefabs[Random.Range(0, 2)], _spawnPositions[Random.Range(0, 8)].position, Quaternion.identity, transform);
        }
    }
}
