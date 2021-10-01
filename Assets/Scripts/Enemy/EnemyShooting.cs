using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public float TimeToShoot=0.5f;
    [SerializeField] float timer;

    public AudioSource ShotSound;
    public GameObject ShotEffect;

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
        ShotSound.Play();
        GameObject effect= Instantiate(ShotEffect,FirePoint.position,FirePoint.rotation);
        Destroy(effect,2f);
        GameObject BulletGO = Instantiate(Preb,FirePoint.position,FirePoint.rotation, transform);
        BulletGO.GetComponent<Rigidbody>().velocity = transform.forward * BulletSpeed;
    }
}
