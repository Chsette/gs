using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;

    void Start()
    {
        pauseMenu.SetActive(false);
    }

    public void ButtonPause()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }
}
