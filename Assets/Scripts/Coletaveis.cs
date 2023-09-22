using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coletaveis : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI frutasTexto;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            ContadorColetaveis.contadorColetaveis++;
            frutasTexto.text = "Você tem: " + ContadorColetaveis.contadorColetaveis + " frutas";
            //Debug.Log("Você tem: " + ContadorColetaveis.contadorColetaveis + " frutas");
        }
    }
}
