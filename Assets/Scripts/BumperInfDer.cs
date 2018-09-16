using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperInfDer : MonoBehaviour
{

    public BolaProvisional bola;
    public ObjetoGeneral objetoGeneral;
    public AudioSource rebote;

    public bool teletransportada;
    public int contador;

    void Awake()
    {
        
    }

    void Start()
    {

    }

    void Update()
    {

    }

    void FixedUpdate()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bola")

        {
            objetoGeneral.MiniBumperInferioresGolpeado();
      //      bola.rigidBody2D.AddForce(Vector2.right * 11 * 1000000, ForceMode2D.Force);
            bola.rigidBody2D.AddForce(new Vector2(-0.6f, 1) * 11 * 1000000, ForceMode2D.Force);
            PlayRebote();
        }
        // bola.rigidBody2D.AddForce(new Vector2(1, 1) *90000, ForceMode2D.Force);

    }

    public void PlayRebote()
    {
        rebote.Play();
    }

}
