using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poder : MonoBehaviour
{
    [SerializeField] float velocidade = 5f;

    private void Update()
    {
        transform.Translate(new Vector2((velocidade * Time.deltaTime), 0));
    }
}
