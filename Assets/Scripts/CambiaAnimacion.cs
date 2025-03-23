using System;
using UnityEngine;

public class CambiaAnimacion : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer spRenderer;
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        spRenderer=GetComponent<SpriteRenderer>();
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Animator
        animator.SetFloat("velocidadX1", MathF.Abs(rb.linearVelocityX));
        animator.SetBool("enPiso", EstadoPersonaje.enPiso);
        // RENDERER
        spRenderer.flipX = rb.linearVelocityX < 0;
    }
    
    
}
