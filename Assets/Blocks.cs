using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    public GameObject NormalWall;
    public GameObject DestroyedBlock;

    BoxCollider boxCollider;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<BulletCollision>())
        {
            SwitchModels();
        }
    }

    void SwitchModels()
    {
        boxCollider.enabled = false;
        DestroyedBlock.SetActive(true);
        Destroy(NormalWall);
        Destroy(gameObject,6f);
    }
}
