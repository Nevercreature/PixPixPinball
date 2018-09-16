using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class BotonPlay : MonoBehaviour {

    public Animator botonPlay;
    public bool botonPlayPulsado;

    private void Awake()
    {
      
    }

    void Start () {
  
    }
	
	void FixedUpdate () {

    }

    void Update()
    {

        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {

            botonPlayPulsado = true;
        }

        if (CrossPlatformInputManager.GetButtonUp("Jump"))
        {
            botonPlayPulsado = false;


        }

        botonPlay.SetBool("pulsado",botonPlayPulsado);



    }
    }
