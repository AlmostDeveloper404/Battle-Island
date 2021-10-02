using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    AudioSource BoostSound;

    private void Awake()
    {
        BoostSound = GetComponent<AudioSource>();
        if (instance!=null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }

    
    public void PlaySound(AudioSource sound)
    {
        BoostSound.clip = sound.clip;
        BoostSound.Play();
    }
}
