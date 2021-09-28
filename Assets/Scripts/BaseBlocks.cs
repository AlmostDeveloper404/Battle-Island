using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBlocks : MonoBehaviour
{
    [SerializeField] private GameObject _defoltblocks, _concreteBlocks;

    public void GetConcreteBlock()
    {
        _defoltblocks.SetActive(false);
        _concreteBlocks.SetActive(true);

        Invoke("GetDefoltBlock", 5);
    }

    void GetDefoltBlock()
    {
        _defoltblocks.SetActive(true);
        _concreteBlocks.SetActive(false);
    }
}