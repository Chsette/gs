using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;
    public AudioSource buttonPress;
    public void ButtonPressed()
    {
        buttonPress.Play();
    }

    void Start()
    {
        pauseMenu.SetActive(false);
    }


    public void ButtonPause()
    {
        ButtonPressed();
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }
}
