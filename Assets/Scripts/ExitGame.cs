using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public AudioSource buttonPress;
    public void ButtonPressed()
    {
        buttonPress.Play();
    }
    public void Exit()
    {
        ButtonPressed();
        Application.Quit();
    }
}
