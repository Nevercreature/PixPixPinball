using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class BotonLeft : MonoBehaviour {

    public Animator botonLeft;
    public Animator flipperLeft;

    public bool botonLeftPulsado;

    private void Awake()
    {
      
    }

    void Start () {
  
    }
	
	void FixedUpdate () {

    }

    void Update()
    {

        if (CrossPlatformInputManager.GetButtonDown("Fire1"))
        {

            botonLeftPulsado = true;
        }

        if (CrossPlatformInputManager.GetButtonUp("Fire1"))
        {
            botonLeftPulsado = false;


        }

        botonLeft.SetBool("pulsado",botonLeftPulsado);
        


    }
    }
