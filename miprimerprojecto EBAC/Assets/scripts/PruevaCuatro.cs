using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruevaCuatro : MonoBehaviour
{
    public bool BoolCuatro;
    public PruebaUno BoolUno;
    public PruebaDos BoolDos;
    Color w = Color.white;
    Color b = Color.black;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        
        if  (BoolUno.BoolUno  && BoolDos.BoolDos )
            
        {
            BoolCuatro = true;
            GetComponent<MeshRenderer>().material.color = w;
        }
        else
        {
            BoolCuatro = false;
            GetComponent<MeshRenderer>().material.color = b;
        }
    }
}
