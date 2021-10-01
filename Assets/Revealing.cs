using UnityEngine;
using System.Collections;

public class Revealing : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(ScaleIncreasing());
    }

    IEnumerator ScaleIncreasing()
    {
        for (float i = 0; i < 1; i+=Time.deltaTime)
        {
            transform.localScale = new Vector3(i,i,i);
            yield return null;
        }
        transform.localScale = Vector3.one;
    }

}
