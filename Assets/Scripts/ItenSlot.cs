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
            // Move o item para a posi��o da c�lula
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

            // Verifica a tag do objeto arrastado
            string itemTag = eventData.pointerDrag.tag;

            // Adiciona o condicional baseado na tag
            switch (itemTag)
            {
                case "F�ssil":
                    Debug.Log("Item de tipo F�ssil foi dropado.");
                    // Adicione a l�gica espec�fica para "F�ssil" aqui
                    break;

                case "Biomassa":
                    Debug.Log("Item de tipo Biomassa foi dropado.");
                    // Adicione a l�gica espec�fica para "Biomassa" aqui
                    break;

                case "E�lica":
                    Debug.Log("Item de tipo E�lica foi dropado.");
                    // Adicione a l�gica espec�fica para "E�lica" aqui
                    break;

                case "Nuclear":
                    Debug.Log("Item de tipo Nuclear foi dropado.");
                    // Adicione a l�gica espec�fica para "Nuclear" aqui
                    break;

                default:
                    Debug.LogWarning("O item dropado tem uma tag n�o reconhecida.");
                    break;
            }
        }
    }
}
