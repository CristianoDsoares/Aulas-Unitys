using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicaoDuo : MonoBehaviour
{
    /* Start is called before the first frame update
    void Start()
    {
        
    }

   / / Update is called once per frame*/
    void Update()

    {

      

            if (transform.position.y < 1)
            {
                            // Modificando a posiçaao de Objeto
                            //transform.position = new Vector3(transform.position.x,0, transform.position.z);
                            // Adicionando efeitos dos componentes

                GetComponent<Rigidbody>().AddForce (Vector3.up*500);
            }

        
                    
        
    }


}