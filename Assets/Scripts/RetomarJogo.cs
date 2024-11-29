using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetomarJogo : MonoBehaviour
{
    public GameObject pauseMenu;
    public AudioSource buttonPress;
    public void ButtonPressed()
    {
        buttonPress.Play();
    }
    public void ButtonResume()
    {
        ButtonPressed();
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }
}
