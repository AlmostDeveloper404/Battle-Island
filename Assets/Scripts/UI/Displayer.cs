using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Displayer : MonoBehaviour
{
    [SerializeField] private PlayerHealth _playerHealth;

    
    [SerializeField] private Text _textHealth;

    void Start()
    {
        DisplayHealth();
    }
    
    public void DisplayHealth()
    {
        _textHealth.text = $"{_playerHealth.GetHealth()}";
    }
}
