using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostsBlink : MonoBehaviour
{
    [SerializeField] private Renderer[] _renderers;

    void Start()
    {
        StartCoroutine(Blink());
    }
    
    private IEnumerator Blink()
    {
        for (float t = 0; t < 10; t += Time.deltaTime)
        {
            for(int r = 0; r < _renderers.Length; r++)
            {
                for(int m = 0; m < _renderers[r].materials.Length; m++)
                {
                    if(t >= 5)
                    {
                        Debug.Log("hi");
                        Color color = _renderers[r].materials[m].color;
                        _renderers[r].materials[m].SetColor("_Color", new Color(color.r, color.g, color.b, Mathf.Sin(t * 30) * 0.5f + 0.5f));
                    }
                }
            }
            yield return null;
        }
    }
}
