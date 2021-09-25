using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

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
        Vector3 direction = Vector3.zero; 

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if(Mathf.Abs(horizontal) > Mathf.Abs(vertical))
        {
            if(horizontal > 0)
            {
                direction = Vector3.right;
            }
            else
            {
                direction = Vector3.left;
            }
        }
        else if(Mathf.Abs(vertical) > Mathf.Abs(horizontal))
        {
            if(vertical > 0)
            {
                direction = Vector3.forward;
            }
            else
            {
                direction = Vector3.back;
            }
        }

        return direction;
    }



}
