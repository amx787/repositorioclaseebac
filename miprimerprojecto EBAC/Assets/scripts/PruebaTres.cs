using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaTres : MonoBehaviour
{
    public bool BoolTres;
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


        if (BoolUno.BoolUno || BoolDos.BoolDos)
        {

            BoolTres = true;
            GetComponent<MeshRenderer>().material.color = w;

        }
        else
        {
            BoolTres = false;
            GetComponent<MeshRenderer>().material.color = b;
        }
    }
}
