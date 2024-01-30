using UnityEngine;
using UnityEngine.UI;

public class MorphApp : MonoBehaviour
{
    // UI components
    public Text titleText;
    public Button transformButton;
    public Image image;

    // Font settings
    public Font appFont;
    public int fontSize = 24;

    // Audio components
    public AudioClip mainMenuMusic;
    public AudioClip transformationMusic;
    public AudioClip tickSound;
    public AudioClip portalOpenSound;
    public AudioClip portalCloseSound;

    private AudioSource musicSource;
    private AudioSource soundEffectSource;

    private void Start()
    {
        // Set the app font
        titleText.font = appFont;
        titleText.fontSize = fontSize;

        // Create audio sources
        musicSource = gameObject.AddComponent<AudioSource>();
        soundEffectSource = gameObject.AddComponent<AudioSource>();

        // Play main menu music on app launch
        PlayMusic(mainMenuMusic, true);

        // Add button click event listener
        transformButton.onClick.AddListener(OnTransformButtonClick);
    }

    private void OnTransformButtonClick()
    {
        // Play transformation music
        PlayMusic(transformationMusic, false);

        // Perform transformation logic here

        // Play tick sound
        PlayTickSound();

        // Display transformed image
        DisplayTransformedImage();
    }

    private void DisplayTransformedImage()
    {
        // Set the transformed image in the image component
        // Code to set the image goes here
    }

    public void PlayMusic(AudioClip clip, bool loop)
    {
        musicSource.Stop();
        musicSource.clip = clip;
        musicSource.loop = loop;
        musicSource.Play();
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
