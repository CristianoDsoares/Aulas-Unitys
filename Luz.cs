using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luz : MonoBehaviour
{
    
    /*// Start is called before the first frame update
    void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
          if (GetComponent<Light> ().enabled == true)
        {
            Debug.Log ("A Luz esta Acesa");

        }else


         {

             Debug.Log ("A Luz Não esta Acesa");


        }

        
    }
}
