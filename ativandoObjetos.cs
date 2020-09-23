using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ativandoObjetos : MonoBehaviour
{
    public GameObject objeto;

    
    // Start is called before the first frame update
    void Start()
    {
       if (GetComponent<MeshRenderer>().enabled == false)
        {
            Debug.Log("A malha do Objeto Esta desativada");
        }else

        {

             Debug.Log("A malha do Objeto Esta ativada");

        }
        
        
    }

    

    // Update is called once per frame
    void Update()
    {
        // Desabilitar Objeto baseado em outro
        if (objeto.activeInHierarchy == false)
        {
             Debug.Log("O cubo esta inativo");
        }
           else
            {
                Debug.Log("O Cubo esta Ativo"); 
            
            
            }  
  
  
    }  
    



}
