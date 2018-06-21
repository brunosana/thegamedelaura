using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerNPC : MonoBehaviour
{

    Animator Animador;
    float velocidade =  2;
    Rigidbody2D rb2d;
    bool isMoving;
    public static bool canMove;
    public static void setcanMove(bool a) { canMove = a; }
    void Awake()
    {
        canMove = true;
        isMoving = false;
        rb2d = GetComponent<Rigidbody2D>();
        Animador = GetComponent<Animator>();
        Animador.SetBool("parado", false);
        Animador.SetBool("oeste", false);
        Animador.SetBool("leste", false);
        Animador.SetBool("norte", false);
        Animador.SetBool("sul", false);
    }


    void Update()
    {
        if (!isMoving && canMove) {
            StartCoroutine(NPCmove());
        }

    }

    IEnumerator NPCmove() {
        isMoving = true;
        Animador.SetBool("parado", false);
        Animador.SetBool("oeste", false);
        Animador.SetBool("leste", true);
        Animador.SetBool("norte", false);
        Animador.SetBool("sul", false);
        rb2d.velocity = new Vector2(velocidade, 0);
        yield return new WaitForSeconds(3);
        rb2d.velocity = new Vector2(0,0);
        Animador.SetBool("leste", false);
        Animador.SetBool("parado", true);
        yield return new WaitForSeconds(1);
        Animador.SetBool("parado", false);
        Animador.SetBool("oeste", true);
        rb2d.velocity = new Vector2(-velocidade, 0);
        yield return new WaitForSeconds(3);
        rb2d.velocity = new Vector2(0, 0);
        Animador.SetBool("oeste", false);
        Animador.SetBool("parado", true);
        yield return new WaitForSeconds(1);
        isMoving = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            dialogSystem.start = true;
        }

    }
}