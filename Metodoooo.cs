using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metodoooo : MonoBehaviour
{
    public int numero = 0;
    
    // Update is called once per frame
    public void Update()
    {
        transform.Translate(100*Time.deltaTime,0,0);

        numero = 10;
        
    }


    public void LateUpdate()
    {
          numero = 20;
        
    }


}
