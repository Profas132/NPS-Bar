using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioClip[] bellSounds;
    [SerializeField] AudioClip[] doorBellSounds;
    [SerializeField] AudioClip[] dialogueSounds;
    AudioSource audioSource;

    public static SoundManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        audioSource = GetComponent<AudioSource>();
    }


    public void playBellSound()
    {
        audioSource.clip = bellSounds[Random.Range(0, bellSounds.Length)];
        audioSource.Play();
    }

    public void playDoorBellSound()
    {
        audioSource.clip = doorBellSounds[Random.Range(0, doorBellSounds.Length)];
        audioSource.Play();
    }

    public void playDialogueSound()
    {
        audioSource.clip = dialogueSounds[Random.Range(0, dialogueSounds.Length)];
        audioSource.Play();
    }
}
