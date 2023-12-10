using UnityEngine;

public class AudioToggle : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isMuted = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ToggleSound()
    {
        isMuted = !isMuted;
        audioSource.mute = isMuted;
    }
}