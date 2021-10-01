using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] private float _time;

    void Start()
    {
        Destroy(gameObject, _time);
    }
}
