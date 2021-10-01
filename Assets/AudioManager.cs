using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource Sound;

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
        Sound.clip = sound.clip;
        Sound.Play();
    }
}
