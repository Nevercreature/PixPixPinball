using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBumper : MonoBehaviour
{

    public ObjetoGeneral objetoGeneral;
    public Rigidbody2D rigidBody2D;
    public PhysicsMaterial2D material;
    public BolaProvisional bola;
    public bool golpeado;
    public int contador;
    public Animator animador;
    public AudioSource rebote;

    void Awake()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Start()
    {

    }

    void Update()
    {
        if (golpeado == true)
        {
            contador++;
        }
        if (contador >= 20)
        {
            golpeado = false;
            contador = 0;
        }

        animador.SetBool("Golpeado",golpeado);


    }

    void FixedUpdate()
    {
        // material.bounciness = 0;

    }



    /*
    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.tag == "bola")

        {

            objetoGeneral.MiniBumperGolpeado();
            material.bounciness = 1.1f;

        }
       



    }

*/
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bola")

        {
            PlayRebote();
            golpeado = true;
            bola.rigidBody2D.velocity.Set(bola.rigidBody2D.velocity.x-2, bola.rigidBody2D.velocity.y*-2);
            objetoGeneral.MiniBumperGolpeado();
         
        //  bola.rigidBody2D.AddForce(new Vector2(bola.rigidBody2D.velocity.x*-1, bola.rigidBody2D.velocity.y*-1) * 11 * 1000000, ForceMode2D.Force);
        //    bola.rigidBody2D.AddForce((rigidBody2D.velocity*-1) * 11 * 1000000, ForceMode2D.Force);

        }

    }

    public void PlayRebote()
    {
        rebote.Play();
    }
}