using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaUno : MonoBehaviour
{
    public bool BoolUno = true;
    Color w = Color.white;
    Color b = Color.black;
     
    
    
    // Start is called before the first frame update
    void Start()
    {
              
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (BoolUno == true)
        {
            BoolUno = false;
            GetComponent<MeshRenderer>().material.color = b;  
        }
        else
        {
            BoolUno = true;
            GetComponent<MeshRenderer>().material.color = w;  
        }

        
    }
}
