using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ItenSlot : MonoBehaviour, IDropHandler
{
    public TextMeshProUGUI health;
    public GameObject cell;
    public float scoreValue = 0f;
    private float polutionRate;

    public void SoloDepleted()
    {
        cell.SetActive(false);
    }


    void FixedUpdate()
    {
        health.text = ((int)scoreValue).ToString();
        scoreValue -= polutionRate * Time.fixedDeltaTime;

        int healthValue = int.Parse(health.text);

        if (healthValue == 0)
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
                    polutionRate = 20;
                    break;

                case "Biomassa":
                    Debug.Log("Item de tipo Biomassa foi dropado.");
                    polutionRate = 16;
                    break;

                case "E�lica":
                    Debug.Log("Item de tipo E�lica foi dropado.");
                    polutionRate = 10;
                    break;

                case "Nuclear":
                    Debug.Log("Item de tipo Nuclear foi dropado.");
                    polutionRate = 2;
                    break;

                default:
                    Debug.LogWarning("O item dropado tem uma tag n�o reconhecida.");
                    break;
            }
        }
    }
}
