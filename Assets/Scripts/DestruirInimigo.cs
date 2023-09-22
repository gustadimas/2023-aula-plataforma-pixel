using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirInimigo : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Poder"))
        {
            Destroy(gameObject);
        }
    }
}
