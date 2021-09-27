using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] _boostPrefabs;
    [SerializeField] private Transform[] _spawnPositions;

    [SerializeField] private float _spawnTimer;

    private int _boostsInGame;

    private float _timer, _timerToRemove;

    void Update()
    {
        if(_boostsInGame < 1)
        {
            _timer += Time.deltaTime;

            if(_timer >= _spawnTimer)
            {
                _timer = 0f;

                GameObject newBoost = Instantiate(_boostPrefabs[Random.Range(0, 3)], _spawnPositions[Random.Range(0, 8)].position, Quaternion.identity, transform);
                _boostsInGame ++;

                Renderer renderer = newBoost.GetComponentInChildren<Renderer>();
                Color color = renderer.material.color;
                StartCoroutine(StartTimeToDelete(newBoost, renderer, color));
            }
        }
    }

    public void DeductBoostInGame()
    {
        _boostsInGame --;
    }

    public IEnumerator StartTimeToDelete(GameObject boost, Renderer boostRenderer, Color boostColor)
    {
        for (float t = 0; t < 10; t += Time.deltaTime)
        {
            if(t >= 5 && boostRenderer != null)
            {
                boostRenderer.material.SetColor("_Color", new Color(boostColor.r, boostColor.g, boostColor.b, Mathf.Sin(t * 30) * 0.5f + 0.5f));
            }
            if(t >= 8 && boost != null)
            {
                Destroy(boost);
                _boostsInGame--;
            }
            yield return null;
        }
    }
}
