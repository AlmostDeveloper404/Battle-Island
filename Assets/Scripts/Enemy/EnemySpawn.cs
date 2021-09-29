using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemyPrefabs;

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
        int randomEnemy = Random.Range(0,4);
        Vector3 randomPosition = _spawnTransforms[Random.Range(0, 3)].position;
        Vector3 enemyPosition = new Vector3(randomPosition.x, _enemyPrefabs[randomEnemy].transform.position.y, randomPosition.z);

        GameObject newEnemy = Instantiate(_enemyPrefabs[randomEnemy], enemyPosition, _spawnTransforms[0].rotation, transform);
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