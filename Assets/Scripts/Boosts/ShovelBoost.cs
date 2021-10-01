using UnityEngine;

public class ShovelBoost : MonoBehaviour
{
    private BaseBlocks _baseBlocks;
    public AudioSource ShovelSound;
    AudioManager audioManager;

    void Awake() 
    {
        _baseBlocks = FindObjectOfType<BaseBlocks>();
    }

    private void Start()
    {
        audioManager = AudioManager.instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.attachedRigidbody)
        {
            if(other.attachedRigidbody.GetComponent<PlayerHealth>())
            {
                audioManager.PlaySound(ShovelSound);
                _baseBlocks.GetConcreteBlock();
                Destroy(gameObject);
            }
        }
    }
}
