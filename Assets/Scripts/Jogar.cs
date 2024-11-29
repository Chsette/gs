using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogar : MonoBehaviour
{
    public AudioSource buttonPress;
    public void ButtonPressed()
    {
        buttonPress.Play();
    }
    public void GoToPlay()
    {
        ButtonPressed();
        SceneManager.LoadScene("SampleScene");
    }
}
