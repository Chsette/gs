using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorChange : MonoBehaviour
{   public GameObject intactTile; // Objeto do tileset intacto
    public GameObject brokenTile; // Objeto do tileset quebrado
    public float timeToBreak = 5f; // Tempo em segundos antes de o chão quebrar
    private float timer; // Temporizador para rastrear o tempo restante
    private bool isTimerRunning = false; // Controla se o temporizador está ativo

    void Start()
    {
        // Garante que apenas o tile intacto está ativo no início
        if (intactTile != null) intactTile.SetActive(true);
        if (brokenTile != null) brokenTile.SetActive(false);

        // Inicializa o timer e o ativa
        timer = timeToBreak;
        isTimerRunning = true;
    }

    void Update()
    {
        // Reduz o timer enquanto está ativo
        if (isTimerRunning)
        {
            timer -= Time.deltaTime;

            // Quando o tempo acabar, troca o tileset
            if (timer <= 0)
            {
                SwapTiles();
                isTimerRunning = false; // Para o temporizador
            }
        }
    }

    private void SwapTiles()
    {
        if (intactTile != null) intactTile.SetActive(false); // Desativa o tile intacto
        if (brokenTile != null) brokenTile.SetActive(true);  // Ativa o tile quebrado
    }
}
