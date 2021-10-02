using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource BoostSound;

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
}
