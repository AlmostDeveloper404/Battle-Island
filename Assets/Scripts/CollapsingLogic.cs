using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollapsingLogic : MonoBehaviour
{
    Transform[] meshParts;
    void Start()
    {
        meshParts = new Transform[transform.childCount];
        for (int i = 0; i < meshParts.Length; i++)
        {
            meshParts[i] = transform.GetChild(i);
        }

        StartCoroutine(Disappearance());
    }

    IEnumerator Disappearance()
    {
        for (float i = 1; i >0; i-=Time.deltaTime*2f)
        {
            for (int x = 0; x < meshParts.Length; x++)
            {
                meshParts[x].localScale = new Vector3(i,i,i);
                yield return null;
            }
        }
        
    }

    



}
