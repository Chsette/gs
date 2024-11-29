using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoltarAoMenu : MonoBehaviour
{
    public AudioSource buttonPress;
    public void ButtonPressed()
    {
        buttonPress.Play();
    }
    public void GoToMenu()
    {
        ButtonPressed();
        SceneManager.LoadScene("MainMenu");
    }
}
