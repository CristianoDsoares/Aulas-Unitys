using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaled : MonoBehaviour
{

    public Transform cam; 
    /*// Start is called before the first frame update
    void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {

         transform.LookAt  (cam);

          if (Input.GetKey(KeyCode.E))
        {
            //Mudando de posicao Bruscamente
            transform.Translate (50*Time.deltaTime,0,0);
        } 

       
          if (Input.GetKey(KeyCode.R))
        {
            //Mudando a Escala do Objeto
            transform.localScale =   new Vector3 (500,500,500);
        } 
        
        if (Input.GetKey(KeyCode.T))
        {
            //Mudando a Escala de forma Suave Objeto
            transform.localScale =  Vector3.Lerp (transform.localScale,new Vector3 (-5,-5,-5),Time.deltaTime);
           // (transform.localScale,new Vector3 (5,5,5),Time.deltaTime);
        } 

          if (Input.GetKey(KeyCode.Y))
        {
            //fazer o  Objeto olhar para o ponto Zero da Cena
            transform.LookAt  (Vector3.zero);
           // (transform.localScale,new Vector3 (5,5,5),Time.deltaTime);
        } 

        /*if (Input.GetKey(KeyCode.U))
        {
            //fazer o  Objeto lookAt olhar para a camera
            transform.LookAt  (Cam);
           // (transform.localScale,new Vector3 (5,5,5),Time.deltaTime);
        } */
        
    }
}
