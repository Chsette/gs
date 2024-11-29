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
    private float polutionRate;
    private float carbonValue;

    public void SoloDepleted()
    {
        cell.SetActive(false);
    }

    void FixedUpdate()
    {
        scoreValue = Mathf.Clamp(scoreValue, 0, 100);

        health.text = ((int)scoreValue).ToString();

        scoreValue += polutionRate * Time.fixedDeltaTime;

        // Envia créditos de carbono acumulados para o CarbonManager
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
            // Move o item para a posição da célula
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

            // Verifica a tag do objeto arrastado
            string itemTag = eventData.pointerDrag.tag;

            // Adiciona o condicional baseado na tag
            switch (itemTag)
            {
                case "Fóssil":
                    Debug.Log("Item de tipo Fóssil foi dropado.");
                    polutionRate = -20;
                    carbonValue = 20;
                    break;

                case "Biomassa":
                    Debug.Log("Item de tipo Biomassa foi dropado.");
                    polutionRate = -16;
                    carbonValue = 100;
                    break;

                case "Eólica":
                    Debug.Log("Item de tipo Eólica foi dropado.");
                    polutionRate = -10;
                    carbonValue = 300;
                    break;

                case "Nuclear":
                    Debug.Log("Item de tipo Nuclear foi dropado.");
                    polutionRate = -2;
                    carbonValue = 10000;
                    break;

                case "Recuperacao":
                    Debug.Log("Solo sendo recuperado.");
                    polutionRate = 1;
                    carbonValue = 0;
                    break;

                default:
                    Debug.LogWarning("O item dropado tem uma tag não reconhecida.");
                    break;
            }
        }
    }
}
