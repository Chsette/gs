using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguePass : MonoBehaviour
{
    public GameObject slideAtual;
    public GameObject proxSlide;

    public void SlidePass()
    {
        proxSlide.SetActive(true);
        slideAtual.SetActive(false);
    }
}
