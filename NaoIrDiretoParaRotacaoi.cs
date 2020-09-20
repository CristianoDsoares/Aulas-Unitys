using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaoIrDiretoParaRotacaoi : MonoBehaviour
{
    /*// Start is called before the first frame update
    void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            //nao ir direto para rotaçao
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, Time.deltaTime);
        }
        
    }
}
