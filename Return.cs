using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return  : MonoBehaviour
{
    public int numero = 0;
    
    // Update is called once per frame
   /* public void Update()
    {
        transform.Translate(0,0,0);

        numero = 10;
        
    }


    public void LateUpdate()
    {
          numero = 20;
        
    }*/

 void Update() {
        
    }

      void OnTriggerEnter() 
        {

            numero = 60;         
        }

      void OnTriggerExit( ) 
        {

            numero = 0;         
     }


        void OnMouserEnter( )
        {

            numero = 5;         
        }

         void OnMouseExit() {

             numero = 0;
            

        }
        public void MorteDoInimigo(int numeroMorte){

            numero  = numeroMorte;
        }
    
    
    
}
