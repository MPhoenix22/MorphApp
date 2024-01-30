using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Audio clips
    public AudioClip mainMenuMusic;
    public AudioClip transformationMusic;
    public AudioClip tickSound;
    public AudioClip portalOpenSound;
    public AudioClip portalCloseSound;

    // Audio sources
    private AudioSource musicSource;
    private AudioSource soundEffectSource;

    private void Start()
    {
        // Create audio sources
        musicSource = gameObject.AddComponent<AudioSource>();
        soundEffectSource = gameObject.AddComponent<AudioSource>();

        // Play main menu music on app launch
        PlayMusic(mainMenuMusic, true);
    }

    public void PlayMusic(AudioClip clip, bool loop)
    {
        musicSource.Stop();
        musicSource.clip = clip;
        musicSource.loop = loop;
        musicSource.Play();
    }

    public void PlayTransformationMusic()
    {
        PlayMusic(transformationMusic, true);
    }

    public void PlayTickSound()
    {
        soundEffectSource.PlayOneShot(tickSound);
    }

    public void PlayPortalOpenSound()
    {
        soundEffectSource.PlayOneShot(portalOpenSound);
    }

    public void PlayPortalCloseSound()
    {
        soundEffectSource.PlayOneShot(portalCloseSound);
    }
}
