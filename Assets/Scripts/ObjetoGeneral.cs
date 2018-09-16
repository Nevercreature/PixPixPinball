using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetoGeneral : MonoBehaviour {

    public Text textoScore;
    public Text textoVidas;
    public string textoCeros;
    public int score=0;
    public bool bumperGolpeado;
    public int multiplicador;

    public int contadorParaInicio;

    public Bumper bumper01;
    public Bumper bumper02;
    public Bumper bumper03;

    public int estadoBumper01;
    public int estadoBumper02;
    public int estadoBumper03;

    public bool detonanteBumper;
    public bool detonanteBumper2;

    public int vidas;

    public LuzVerde luz01;
    public LuzVerde luz02;
    public LuzVerde luz03;
    public LuzVerde luz04;
    public LuzVerde luz05;

    public bool detonanteLuzVerde;
    public int  detonanteLuzVerde02;

    public bool luzVerde01_encendida;
    public bool luzVerde02_encendida;
    public bool luzVerde03_encendida;
    public bool luzVerde04_encendida;
    public bool luzVerde05_encendida;

    public AudioSource flipper;
    public AudioSource bip001;
    public AudioSource bip002;
    public AudioSource bip003;
    public AudioSource bip004;
    public AudioSource bip005;
    public AudioSource bip006;
    public AudioSource bip007;
    public AudioSource bip008;
    public AudioSource pierdeBola;
    public AudioSource powerUp;
    public AudioSource punch;
    public AudioSource rebote01;
    public AudioSource rebote02;
    public AudioSource rebote03;
    public AudioSource error;
    public AudioSource powerUp2;


    void Awake()
    {
        contadorParaInicio = 0;
        multiplicador = 1;
     bumper01.estado = 1;
     bumper02.estado = 2;
     bumper03.estado = 3;

        detonanteBumper = false;
        detonanteBumper2 = false;


        vidas = 3;

    }

    void Start ()
    {
		
	}
	
	void Update ()
    {
        if (score >= 10000000) { textoCeros = ""; }
        else if (score >= 1000000) { textoCeros = "0"; }
        else if (score >= 100000) { textoCeros = "00"; }
        else if (score >= 10000) { textoCeros = "000"; }
        else if (score >= 1000) { textoCeros = "0000"; }
        else if (score >= 100) { textoCeros = "00000"; }
        else if (score >= 0) { textoCeros = "00000000"; }

         textoScore.text = textoCeros + score;
        // textoScore.text = ""+ score;

        luzVerde01_encendida = luz01.iniciador;
        luzVerde02_encendida = luz02.iniciador;
        luzVerde03_encendida = luz03.iniciador;
        luzVerde04_encendida = luz04.iniciador;
        luzVerde05_encendida = luz05.iniciador;

        estadoBumper01 = bumper01.estado;
        estadoBumper02 = bumper02.estado;
        estadoBumper03 = bumper03.estado;

        contadorParaInicio++;

        if (contadorParaInicio >= 20) { contadorParaInicio = 20; }
    }

    void FixedUpdate()
    {

        if (estadoBumper02 == estadoBumper03 && estadoBumper02 == estadoBumper01 && detonanteBumper == false && detonanteBumper2 == false && contadorParaInicio > 20)      //Tocar aqu� 
        {
            detonanteBumper = true;
            detonanteBumper2 = true;
        }

        if ((estadoBumper02 != estadoBumper03) || (estadoBumper02 != estadoBumper01))     
        {
           
            detonanteBumper2 = false;
        }

        if (estadoBumper01 == 1 && detonanteBumper == true && contadorParaInicio == 20)
        {
            PlayPowerup();
            score += 10000 * multiplicador;
            vidas += 1;
            detonanteBumper = false;
        }

        if (estadoBumper01 == 2 && detonanteBumper == true && contadorParaInicio == 20)
        {
            PlayPowerup();
            score += 6000 * multiplicador;
            detonanteBumper = false;
        }

        if (estadoBumper01 == 3 && detonanteBumper == true && contadorParaInicio == 20)
        {
            PlayPowerup();
            score += 3000 * multiplicador;
            detonanteBumper = false;
        }

        if (estadoBumper01 == 3 && detonanteBumper == true && contadorParaInicio == 20)
        {
            PlayError();
            multiplicador = 1;
            detonanteBumper = false;
        }

        if (vidas <= 0)

        {
            vidas = 0;
        }

        if (vidas >= 9)
        {
            vidas = 9;
        }

        if (multiplicador >= 3)
            {
            multiplicador = 3;
        }

        if (luzVerde01_encendida == true && luzVerde02_encendida == true && luzVerde03_encendida == true &&
            luzVerde04_encendida == true && luzVerde05_encendida == true)
        {

            detonanteLuzVerde = true;


        }

        else { detonanteLuzVerde = false; }

        if (detonanteLuzVerde == true)
        {
            detonanteLuzVerde02++;
        }
        else { detonanteLuzVerde02 = 0; }

        if (detonanteLuzVerde == true && detonanteLuzVerde02 == 0)
        {
            multiplicador += 1;
        
        }

        if (multiplicador >= 3)
        {
            multiplicador = 3;
        }



    }

    public void BumperGolpeado()
    {
        score += 2000 * multiplicador;
        Debug.Log("Suma");
    }

    public void MiniBumperGolpeado()
    {
        score += 500 * multiplicador;
        Debug.Log("Suma");
    }

    public void MiniBumperInferioresGolpeado()
    {
        score += 200 * multiplicador;
        Debug.Log("Suma");
    }

    public void SuperScore()
    {
        score += 10000;
        Debug.Log("Suma");
    }

    public void Tubo()
    {
        score += 1000 * multiplicador;
        Debug.Log("Suma");
    }

    public void PlayFlipper()
    {
        flipper.Play();
    }

    public void PlayPowerup()
    {
        powerUp.Play();
    }

    public void PlayPowerup2()
    {
        powerUp2.Play();
    }

    public void PlayError()
    {
        error.Play();
    }

}
