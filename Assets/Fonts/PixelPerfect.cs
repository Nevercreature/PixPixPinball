using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
//PixelPerfect Camera in Unity
//from Marrt
 
public    enum SnapMode {SnapToScreenPixel, SnapToArtPixel};
 
public class PixelPerfect : MonoBehaviour {
 
    public    static PixelPerfect instance;    //Asegurate de que solo existe una instancia de este script.
 
    //PIXELPERFECT VIEWPORT
    public    Camera        cam;
    public    Transform    camAnchor;
 
    public    Transform    followTarget;
 
    public    SnapMode snapMode = SnapMode.SnapToArtPixel;
 
    //pixel perfect & zoom                                  
    private    float    orthoSize;
    public    float    pxPerUnit        = 16f;        //Medidor de unidad, aqui poner el valor de pixel per unity de vuestras texturas.
    private    float    subPixelFactor    = 1f;        //Nivel de Zoom
 
    private    bool    pixelSnapOn = true;
    private    float    snap = 0F;    //Distancia de división del grid
 
    void Awake(){  
        instance = this;  
        Zoom (1F);
    }
 
    void Update(){
        if(Input.GetKey(KeyCode.LeftControl))
        {
        if(Input.GetKeyDown(KeyCode.F1)){Zoom(0.5f);}
        if(Input.GetKeyDown(KeyCode.F2)){Zoom(1f);}
        if(Input.GetKeyDown(KeyCode.F3)){Zoom(2f);}
        if(Input.GetKeyDown(KeyCode.F4)){Zoom(3f);}
        if(Input.GetKeyDown(KeyCode.F5)){Zoom(4f);}    
        }
    }
 
    void LateUpdate(){
        //camerafollow 
        if(followTarget==null)return;
        if(pixelSnapOn){
            camAnchor.position = snapMode == SnapMode.SnapToArtPixel?RoundToArtPixelGrid(followTarget.position) : RoundToScreenPixelGrid(followTarget.position);
        }else{
			camAnchor.position = new Vector3(followTarget.position.x,followTarget.position.y,-10);
			
        }
    }
   
    private    void Zoom(float subPxFactor){
        orthoSize    = GetPixelPerfectOrthoSize(subPxFactor);  
        StartCoroutine(ZoomTransition());
    }
 
    private    IEnumerator ZoomTransition(){ //durante la transiccion, no se aplica pixel perfect
        float timer = 1F;
        while(timer >0F){
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, orthoSize, Time.deltaTime *10F);
            timer-= Time.deltaTime;      
            yield return null;
        }  
        cam.orthographicSize = orthoSize;
    }
 
    private    float GetPixelPerfectOrthoSize(float screenPixelPerSpritePixelWidth){
   
        subPixelFactor = screenPixelPerSpritePixelWidth;    //1 medio 1 ArtPixel = 1 ScreenPixel, 2 medio 1 Art = 2x2 Screen  
        float s = pxPerUnit *subPixelFactor;  
        snap = 1F/pxPerUnit    /subPixelFactor;
        return cam.pixelHeight / s / 2F;
    }
 
    //tomando esta funcion, pasamos la Camara a Screen Pixels
    public    static Vector3 RoundToScreenPixelGrid(Vector3 worldPos){
        float snapArt    = PixelPerfect.instance.snap;
        return new Vector3(    Mathf.Round( worldPos.x / snapArt    )    *snapArt,
                            Mathf.Round( worldPos.y / snapArt    )    *snapArt,
                            -10);
    }
 
    //tomando esta funcion, pasamos la Camara a Art Pixels
    public    static Vector3 RoundToArtPixelGrid(Vector3 worldPos){
        float snapArt    = PixelPerfect.instance.snap * PixelPerfect.instance.subPixelFactor;
        return new Vector3(    Mathf.Round( worldPos.x / snapArt    )    *snapArt,
                            Mathf.Round( worldPos.y / snapArt    )    *snapArt,
                            -10);
    }
   
    //UI-Button (Funciones para usar desde la UI de Unity.)
 
    public    void PixelSnapOn(bool on){
        pixelSnapOn = on;
    }
 
    public    void ToggleSnappingMode(bool art){
        if(art){
            snapMode = SnapMode.SnapToArtPixel;
        }else{
            snapMode = SnapMode.SnapToScreenPixel;
        }
    }
}