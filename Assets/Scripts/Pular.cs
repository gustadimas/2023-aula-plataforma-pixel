using UnityEngine;

public class Pular : MonoBehaviour
{
    public float forcaPulo = 10f;
    public int pulosMaximos = 2;
    private int pulosRestantes;
    private Rigidbody2D rb;
    private Animator animator;
    private bool pulando;
    //private bool caindo;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        pulosRestantes = pulosMaximos;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && pulosRestantes > 0)
        {
            pulando = true;
            rb.velocity = new Vector2(rb.velocity.x, forcaPulo);
            pulosRestantes--;
        }

        //if (rb.velocity.y > 0.1f)
        //{
        //    pulando = true;
        //}

        //else if (rb.velocity.y < -0.1f)
        //{
        //    caindo = true;
        //}

        animator.SetBool("Pulando", pulando);
        //animator.SetBool("Caindo", caindo);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            pulando = false;
            //caindo = false;
            pulosRestantes = pulosMaximos;
        }
    }
}
