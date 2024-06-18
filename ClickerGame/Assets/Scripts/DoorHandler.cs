
using UnityEngine;
using UnityEngine.UI;

public class DoorHandler : MonoBehaviour
{
    public Button doorButton;
    public GameManager gameManager;
    public AudioClip knockSound;
    public ParticleSystem particleSystem;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if(doorButton != null)
        {
            doorButton.onClick.RemoveListener(OnButtonClick);
            doorButton.onClick.AddListener(OnButtonClick);
        }
    }

    private void OnButtonClick()
    {
        if(GameManager.instance != null)
        {
            return;
        }

        if(audioSource != null && knockSound != null)
        {
            audioSource.PlayOneShot(knockSound);
        }

        if(particleSystem != null)
        {
            particleSystem.Play();
        }
    }
}
