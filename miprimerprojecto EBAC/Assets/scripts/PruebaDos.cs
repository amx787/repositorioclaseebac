using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaDos : MonoBehaviour
{
    bool BoolDos;
    Color w = Color.white;
    Color b = Color.black;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (BoolDos == true)
        {
            BoolDos = false;
            GetComponent<MeshRenderer>().material.color = b;
        }
        else
        {
            BoolDos = true;
            GetComponent<MeshRenderer>().material.color = w;   
        }
    }
}
