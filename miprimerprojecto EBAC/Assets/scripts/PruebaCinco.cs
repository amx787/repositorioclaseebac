using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaCinco : MonoBehaviour
{
    public bool BoolCinco;
    public PruebaTres BoolTres;
    public PruevaCuatro BoolCuatro;
    Color w = Color.white;
    Color b = Color.black;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        
        if (BoolTres.BoolTres  && BoolCuatro.BoolCuatro )
        {
            BoolCinco = true;
            GetComponent<MeshRenderer>().material.color = w;
              
        }
        else
        {
            BoolCinco = false;
            GetComponent<MeshRenderer>().material.color = b;       
        }
    }
}
