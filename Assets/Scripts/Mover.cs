using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float velocidadeMovimento = 5.0f; 
    private Rigidbody2D rb;
    private Animator animator;
    private bool andando = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        Vector2 movimento = new Vector2(inputHorizontal * velocidadeMovimento, rb.velocity.y);
        rb.velocity = movimento;

        if (inputHorizontal < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
            andando = true;
        }
        else if (inputHorizontal > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            andando = true;
        }

        else
        {
            andando = false;
        }

        animator.SetBool("Andando", andando);
    }
}







