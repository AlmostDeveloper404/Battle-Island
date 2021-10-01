using UnityEngine;

public class Blocks : MonoBehaviour
{
    public GameObject DestroyedBlock;
    public GameObject CurrentBlocks;
    public AudioSource PlaySound;

    BoxCollider boxCollider;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<BulletTrigger>())
        {
            SwitchModels();
        }
    }

    void SwitchModels()
    {
        PlaySound.Play();
        boxCollider.enabled = false;
        CurrentBlocks.SetActive(false);
        DestroyedBlock.SetActive(true);
        Destroy(gameObject,6f);
    }
}
