using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransportador01 : MonoBehaviour {

    public BolaProvisional bola;
    public ObjetoGeneral objetoGeneral;

    public bool teletransportada;
    public int contador;
    public AudioSource flash;

    void Awake()
    {

    }

    void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    void FixedUpdate()
    {
        if (teletransportada == true)
        {
            bola.rigidBody2D.velocity = new Vector2(0, 0);
            bola.rigidBody2D.transform.position = new Vector3(-52.2f, 101,90);
            contador++;

        }

        if (contador >= 40)
        {
            teletransportada = false;
            PlayFlash();
         
            bola.rigidBody2D.AddForce(Vector2.right * ((Random.Range(90, 110))/10) * 1000000, ForceMode2D.Force);
            contador = 0;

        }
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bola")

        {
            teletransportada = true;
            objetoGeneral.Tubo();
           
        }
        // bola.rigidBody2D.AddForce(new Vector2(1, 1) *90000, ForceMode2D.Force);

    }

    public void PlayFlash()
    {
        flash.Play();
    }

}
