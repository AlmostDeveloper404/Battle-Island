using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    public enum Directions 
    {
        Up,
        Down,
        Right,
        left
    }

    EnemyShooting enemyShooting;

    public float RandomDirection;
    Rigidbody _rigidBody;
    public float Speed=10f;
    float startSpeed;

    Vector3 directionToMove;

    public Directions Direction;

    public float TimeToChangeDirection=2f;

    float timer;

    private void Awake()
    {
        enemyShooting = GetComponent<EnemyShooting>();
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        startSpeed = Speed;
    }

    private void Update()
    {
        if (Direction == Directions.Down)
        {
            transform.rotation = Quaternion.Euler(0f,180f,0f);
            directionToMove = Vector3.back;
        }
        if (Direction == Directions.Up)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            directionToMove = Vector3.forward;
        }
        if (Direction == Directions.Right)
        {
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            directionToMove = Vector3.right;
        }
        if (Direction == Directions.left)
        {
            transform.rotation = Quaternion.Euler(0f, 270f, 0f);
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

    public void FreezeEnemy()
    {
        _rigidBody.velocity = Vector3.zero ;
        Speed = 0;
        enemyShooting.enabled = false;
        enabled = false;
        
    }

    public void Unfreeze()
    {
        Speed=startSpeed;
        enemyShooting.enabled = true;
        enabled = true;
    }
}
