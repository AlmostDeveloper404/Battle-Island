using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public float TimeToShoot=0.5f;
    [SerializeField] float timer;

    public AudioSource ShotSound;
    public GameObject ShotEffect;

    public GameObject Preb;
    public Transform FirePoint;

    public float BulletSpeed;

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
        GameObject effect= Instantiate(ShotEffect,FirePoint.position,transform.rotation);
        Destroy(effect,2f);
        GameObject bulletGO= Instantiate(Preb,FirePoint.position,FirePoint.rotation);
        bulletGO.GetComponent<Rigidbody>().velocity = FirePoint.forward * BulletSpeed;
    }
}
