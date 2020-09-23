using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriarObjetos : MonoBehaviour
{
    public Vector3 posicao, rotacao;
    public GameObject prefab;
    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    */

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
                //criando objetos posionando e girando
                /*
            GameObject objeto = GameObject.CreatePrimitive(PrimitiveType.Cube);
            objeto.transform.position = posicao; 
            objeto.transform.rotation =  Quaternion.Euler(rotacao);
            */

            // Criando objetos com prefabs
            Instantiate(prefab, posicao, Quaternion.Euler(rotacao) );



        }
        
    }
}
