using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushCollision : MonoBehaviour
{
    public AudioSource Bush;
    private void OnTriggerEnter()
    {
        Bush.Play();
    }
}
