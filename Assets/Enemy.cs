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
        if (Direction==Directions.Down)
        {
            MoveDown();
        }
        if (Direction == Directions.Up)
        {
            MoveUp();
        }
        if (Direction==Directions.Right)
        {
            MoveRight();
        }
        if (Direction==Directions.left)
        {
            MoveLeft();
        }

        timer += Time.deltaTime;
        if (timer>TimeToChangeDirection)
        {
            ChangeDirection();
        }
    }

    void MoveUp()
    {
        directionToMove = Vector3.forward;
    }
    void MoveDown()
    {
        directionToMove = Vector3.back;
    }
    void MoveRight()
    {
        directionToMove = Vector3.right;
    }
    void MoveLeft()
    {
        directionToMove = Vector3.left;
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

    private void FixedUpdate()
    {
        _rigidBody.velocity = directionToMove*Speed;
    }

}
