using UnityEngine;

public class Enemy : MonoBehaviour
{
    public enum Directions 
    {
        Up,
        Down,
        Right,
        left
    }

    public float RandomDirection;
    Rigidbody _rigidBody;
    public float Speed=10f;

    Vector3 directionToMove;

    public Directions Direction;

    public float TimeToChangeDirection=2f;

    float timer;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Direction == Directions.Down)
        {
            directionToMove = Vector3.back;
        }
        if (Direction == Directions.Up)
        {
            directionToMove = Vector3.forward;
        }
        if (Direction == Directions.Right)
        {
            directionToMove = Vector3.right;
        }
        if (Direction == Directions.left)
        {
            directionToMove = Vector3.left;
        }

        timer += Time.deltaTime;
        if (timer>TimeToChangeDirection)
        {
            ChangeDirection();
        }
    }

    private void FixedUpdate()
    {
        _rigidBody.velocity = directionToMove * Speed;
    }


    void MoveUp()
    {
        Direction = Directions.Up;
    }
    void MoveDown()
    {
        Direction = Directions.Down;
    }
    void MoveRight()
    {
        Direction = Directions.Right;
    }
    void MoveLeft()
    {
        Direction = Directions.left;
    }

    void ChangeDirection()
    {
        Debug.Log("Yep");
        timer = 0;
        RandomDirection = Random.Range(0,4);
        switch (RandomDirection) 
        {
            case 0:
                MoveUp();
                break;
            case 1:
                MoveDown();
                break;
            case 2:
                MoveRight();
                break;
            case 3:
                MoveLeft();
                break;

        }


    }
}
