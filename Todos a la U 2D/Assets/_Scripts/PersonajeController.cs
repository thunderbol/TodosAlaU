using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeController : MonoBehaviour
{
    public float velMovement = 5f; // Velocidad de movimiento del personaje
    public float fuerzaJump = 7f; //Fuerza de salto dle personaje 
    private bool enElsuelo = false; //Indicador si el personaje está en el suelo


   

    private Rigidbody2D rb;
    private Animator animator;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }


    void Update()
    {

        //movimiento horizonal
        float movimientoH = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(movimientoH * velMovement, rb.velocity.y);

        animator.SetFloat("Horizontal", Mathf.Abs(movimientoH));


        //Salto
        if (Input.GetButtonDown("Jump") && enElsuelo)
        {
            rb.AddForce(new Vector2(0f, fuerzaJump), ForceMode2D.Impulse);
            enElsuelo = false;
        }

    }

        void OnCollisionEnter2D (Collision2D collision)
        {
            //Verificar si el personaje está en el suelo
            if (collision.gameObject.CompareTag("Suelo"))
            {
                enElsuelo = true;
            Debug.Log("Si toco el suelo");
            }
        }

    }

