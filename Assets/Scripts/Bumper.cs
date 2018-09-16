using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{

    public ObjetoGeneral objetoGeneral;
    public Rigidbody2D rigidBody2D;
    public BolaProvisional bola;
    public Animator animador;
    public AudioSource rebote;

    public int estado;  
    // FELIZ
    // RARO
    // EUFORICO
    // TRISTE

    public bool golpeado;

    void Awake()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        estado = 1;
    }

    void Start()
    {

    }

    void Update()
    {


    }

    void FixedUpdate()
    {
        if (estado >= 5)
        {
            estado = 1;
        }

        animador.SetInteger("estado", estado);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bola")

        {
            PlayRebote();
            golpeado = true;
            estado += 1;
           // bola.rigidBody2D.velocity.Set(bola.rigidBody2D.velocity.x*-2, bola.rigidBody2D.velocity.y*-2);
            objetoGeneral.BumperGolpeado();

        }

    }

    public void PlayRebote()
    {
        rebote.Play();
    }
}