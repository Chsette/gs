using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ResetScene : MonoBehaviour
{
    public AudioSource buttonPress;

    public void ButtonPressed()
    {
        buttonPress.Play();
    }
    public void RestartScene()
    {
        ButtonPressed();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
