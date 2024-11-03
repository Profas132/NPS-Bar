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
        //Debug.Log(PlayerPrefs.GetFloat("SoundValue", 50f) / 100f);
        audioSource.volume = PlayerPrefs.GetFloat("SoundValue", 50f) / 100f;
    }
}
