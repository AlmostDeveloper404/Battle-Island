using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public float TimeToShoot=0.5f;
    [SerializeField]float timer;

    public float BulletSpeed;

    public GameObject Preb;
    public Transform FirePoint;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer>TimeToShoot)
        {
            timer = 0;
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject BulletGO= Instantiate(Preb,FirePoint.position,FirePoint.rotation);
        BulletGO.GetComponent<Rigidbody>().velocity = transform.forward * BulletSpeed;
    }
}
