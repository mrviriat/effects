//Данный код не претендует на единственно верное решение и даже на идеальное решение тоже не претендует
//Я знаю какой ты крутой программист, этот код работает и работает неплохо на остальное мне как-то п*хуй

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    private Animator anim;
    public static float moveInput = 0;
    private bool facingRight = true;

    public float speedMain = 3;

    private Rigidbody2D rb;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        moveInput = 0;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveInput * speedMain, rb.velocity.y);

        if (moveInput > 0 || moveInput < 0)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        if (facingRight == false && moveInput > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            Flip();
        }
    }

    public void Flip()
    {
        facingRight = !facingRight;
    }
}
