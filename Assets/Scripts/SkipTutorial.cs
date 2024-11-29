using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipTutorial : MonoBehaviour
{
    public GameObject tutorial;

    public void PularTutorial()
    {
        tutorial.SetActive(false);
    }
}
