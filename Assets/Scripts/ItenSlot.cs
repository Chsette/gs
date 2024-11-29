using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ItenSlot : MonoBehaviour, IDropHandler
{
    public TextMeshProUGUI health;
    public GameObject cell;
    public float scoreValue = 100f;
    public AudioSource celldrop;
    private float polutionRate;
    private float carbonValue;

    public void SoloDepleted()
    {
        cell.SetActive(false);
    }

    public void Celldropped()
    {
        celldrop.Play();
    }

    void FixedUpdate()
    {
        scoreValue = Mathf.Clamp(scoreValue, 0, 100);

        health.text = ((int)scoreValue).ToString();

        scoreValue += polutionRate * Time.fixedDeltaTime;

        // Envia cr�ditos de carbono acumulados para o CarbonManager
        CarbonManager.Instance.AddCarbonCredits(carbonValue * Time.fixedDeltaTime);

        if (scoreValue >= 100)
        {
            polutionRate = 0f;
            scoreValue = 100;
        }

        if (scoreValue <= 0)
        {
            SoloDepleted();
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Dropou");

        if (eventData.pointerDrag != null)
        {
            // Move o item para a posi��o da c�lula
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

            // Verifica a tag do objeto arrastado
            string itemTag = eventData.pointerDrag.tag;

            // Adiciona o condicional baseado na tag
            switch (itemTag)
            {
                case "F�ssil":
                    Debug.Log("Item de tipo F�ssil foi dropado.");
                    polutionRate = -10;
                    carbonValue = 1;
                    Celldropped();
                    break;

                case "Biomassa":
                    //100
                    Debug.Log("Item de tipo Biomassa foi dropado.");
                    polutionRate = -8;
                    carbonValue = 5;
                    Celldropped();
                    break;

                case "E�lica":
                    //850
                    Debug.Log("Item de tipo E�lica foi dropado.");
                    polutionRate = -5;
                    carbonValue = 30;
                    Celldropped();
                    break;

                case "Nuclear":
                    //4500
                    Debug.Log("Item de tipo Nuclear foi dropado.");
                    polutionRate = -2;
                    carbonValue = 100;
                    Celldropped();
                    break;

                case "Recuperacao":
                    Debug.Log("Solo sendo recuperado.");
                    polutionRate = 1;
                    carbonValue = 0;
                    Celldropped();
                    break;

                default:
                    Debug.LogWarning("O item dropado tem uma tag n�o reconhecida.");
                    break;
            }
        }
    }
}
