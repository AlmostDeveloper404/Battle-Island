using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;

    [SerializeField] private Transform[] _spawnTransforms;

    [SerializeField] private float _spawnTimer, _maxEnemysInMoment, _remainingEnemys;

    [SerializeField] private List<GameObject> _enemys = new List<GameObject>();

    [SerializeField] private Text _remainingEnemysText;

    private float _timer;

    void Start()
    {
        SpawnEnemy();
        //DisplayRemainingEnemys();
    }

    void Update()
    {
        if(_enemys.Count < _maxEnemysInMoment && _remainingEnemys > 0)
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
        _remainingEnemys --;
        //DisplayRemainingEnemys();
    }

    public void RemoveFromEnemys(GameObject enemy)
    {
        _enemys.Remove(enemy);
    }

    public List<GameObject> GetEnemys()
    {
        return _enemys;
    }

    //void DisplayRemainingEnemys()
    //{
    //    _remainingEnemysText.text = $"{_remainingEnemys}";
    //}
}