using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    private AudioSource audioSource;
    

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        audioSource.volume = PlayerPrefs.GetFloat("SoundValue", 50f) / 100f;
    }
}
