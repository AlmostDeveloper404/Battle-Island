using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class BoostSpawn : MonoBehaviour
{
    public List<Transform> boosts=new List<Transform>();
    private Transform[] spawnPositions;

    AudioSource spawnSource;

    float _timer;
    public float TimeToSpawnBoost;

    private void Awake()
    {
        spawnSource = GetComponent<AudioSource>();
        spawnPositions = new Transform[transform.childCount];
        for (int i = 0; i < spawnPositions.Length; i++)
        {
            spawnPositions[i] = transform.GetChild(i);
        }
    }

    private void Start()
    {
        _timer = TimeToSpawnBoost;
    }

    private void Update()
    {
        _timer -= Time.deltaTime;
        if (_timer<0)
        {
            _timer = TimeToSpawnBoost;
            SpawnBoost();
        }
    }

    void SpawnBoost()
    {
        if (boosts.Count == 0)
        {
            enabled = false;
            return;
        }
        spawnSource.Play();
        Instantiate(boosts[0], spawnPositions[Random.Range(0,spawnPositions.Length)].position,Quaternion.identity);
        RemoveBoost();
    }

    public void RemoveBoost()
    {
        boosts.RemoveAt(0);
    }
}
