using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] TMP_Text soundValueLabel;
    [SerializeField] Slider slider;
    

    private void Start()
    {
        slider.value = PlayerPrefs.GetFloat("SoundValue", 50f) / 100;
    }

    public void OnStartClick()
    {
        SceneManager.LoadScene("Main");
    }

    public void SliderValueChanged()
    {
        soundValueLabel.text = Mathf.Floor(slider.value * 100f).ToString();
        PlayerPrefs.SetFloat("SoundValue", Mathf.Floor(slider.value * 100f));
    }
}
