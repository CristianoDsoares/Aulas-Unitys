using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle : MonoBehaviour
{
   /* // Start is called before the first frame update
    void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {

            // eulerAngles direciona o objeto para uma rotacao especifica

            transform.eulerAngles = new Vector3 (100*Time.deltaTime,0,0);
        }
            if (Input.GetKey(KeyCode.D))
            {
                transform.eulerAngles = new Vector3 (-100*Time.deltaTime,0,0);
            }

                if (Input.GetKey(KeyCode.W))
                {
                     transform.eulerAngles = new Vector3 (0,100*Time.deltaTime,0);

                }

                    if (Input.GetKey(KeyCode.S))
                    {
                         transform.eulerAngles = new Vector3 (0,-100*Time.deltaTime,0);

                    }      

        
        
        
    }


}




