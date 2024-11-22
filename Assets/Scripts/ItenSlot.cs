using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItenSlot : MonoBehaviour, IDropHandler
{
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
                    // Adicione a lógica específica para "Fóssil" aqui
                    break;

                case "Biomassa":
                    Debug.Log("Item de tipo Biomassa foi dropado.");
                    // Adicione a lógica específica para "Biomassa" aqui
                    break;

                case "Eólica":
                    Debug.Log("Item de tipo Eólica foi dropado.");
                    // Adicione a lógica específica para "Eólica" aqui
                    break;

                case "Nuclear":
                    Debug.Log("Item de tipo Nuclear foi dropado.");
                    // Adicione a lógica específica para "Nuclear" aqui
                    break;

                default:
                    Debug.LogWarning("O item dropado tem uma tag não reconhecida.");
                    break;
            }
        }
    }
}
