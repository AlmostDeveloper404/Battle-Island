using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class BoostSpawn : MonoBehaviour
{
    public List<Transform> boosts=new List<Transform>();
    private Transform[] spawnPositions;

    float _timer;
    public float TimeToSpawnBoost;

    private void Awake()
    {
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
        Transform newBoost = Instantiate(boosts[0], spawnPositions[Random.Range(0,spawnPositions.Length)].position,Quaternion.identity);
        RemoveBoost();

        Renderer renderer = newBoost.GetComponentInChildren<Renderer>();
        Color color = renderer.material.color;
        StartCoroutine(StartTimeToDelete(newBoost, renderer, color));
    }

    public void RemoveBoost()
    {
        boosts.RemoveAt(0);
    }

    public IEnumerator StartTimeToDelete(Transform boost, Renderer boostRenderer, Color boostColor)
    {
        for (float t = 0; t < 10; t += Time.deltaTime)
        {
            if(t >= 5 && boostRenderer != null)
            {
                boostRenderer.material.SetColor("_Color", new Color(boostColor.r, boostColor.g, boostColor.b, Mathf.Sin(t * 30) * 0.5f + 0.5f));
            }
            yield return null;
        }
    }
}
