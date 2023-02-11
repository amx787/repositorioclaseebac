using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaM7Bool5 : MonoBehaviour
{
    public GameObject PrefabCubo;
    public List<GameObject> listaDeCubos;

    bool variable1;
    bool variable2;
    bool variable3;
    int valor1 = 1;
    int limiteInferior = 0;
    int limiteSuperior = 1;
    Color w = Color.white;
    Color b = Color.black;
    enum SeleccionColor
    {
        negro,
        blanco
    }
    // Start is called before the first frame update
    private void Start()
    {
        
    }
    void FixedUpdate()
    {
        variable1 = true;
        variable2 = false;
        variable3 = false;

        if ((variable1 && variable2) && variable2) 
        {

            Debug.Log("la operacion 1 es verdadero");

            GetComponent<MeshRenderer>().material.color = b;

        }


        else
        {

            Debug.Log("la operacion 1 es falsa");

            GetComponent<MeshRenderer>().material.color = w;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
