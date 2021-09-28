using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 _directionToMove;

    private Rigidbody _rigidbody;


    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        _rigidbody.velocity = GetDirection() * _speed;
    }

    Vector3 GetDirection() 
    {
        _directionToMove = Vector3.zero;
        
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.identity;
            _directionToMove = Vector3.forward; 
        }

        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Euler(0f,180f,0f);
            _directionToMove = Vector3.back;
        }

        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            _directionToMove = Vector3.right;
        }
        
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0f, 270f, 0f);
            _directionToMove = Vector3.left;
        }

        return _directionToMove;
    }

    public void IncreaseSpeed()
    {
        _speed *= 2f;
        Invoke("DecreaseSpeed", 5f);
    }

    public void DecreaseSpeed()
    {
        _speed /= 2f;
    }
}
