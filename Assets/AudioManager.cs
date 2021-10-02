using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource BoostSound;
    public AudioSource DeathSounds;

    private void Awake()
    {
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

    public void DeathSound(AudioSource audioSource)
    {
        DeathSounds.clip = audioSource.clip;

        audioSource.Play();
    }
}
