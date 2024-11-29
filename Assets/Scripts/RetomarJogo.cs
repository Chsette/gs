using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetomarJogo : MonoBehaviour
{
    public GameObject pauseMenu;
    public void ButtonResume()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }
}
