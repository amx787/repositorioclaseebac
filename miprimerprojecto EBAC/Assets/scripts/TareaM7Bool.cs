using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaM7Bool : MonoBehaviour
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
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        variable1 = true;
        variable2 = false;
        variable3 = false;



        {
            if (variable1 && variable1) 
            { 

               Debug.Log("la operacion 1 es verdadero");

               GetComponent<MeshRenderer>().material.color = b; 
             
            }


            else
            {               

                Debug.Log("la operacion 1 es falsa");

                GetComponent<MeshRenderer>().material.color = w;
            }



            //valor1 = Random.Range(limiteInferior, limiteSuperior);
            //Debug.Log(valor1);

            //string resultado = (valor1 >= 1) ? "el valor es positivo" : "el valor es negartivo";
            //Debug.Log(resultado);

            //switch (valor1)
            //{

            //    case (int)SeleccionColor.negro:
            //        Debug.Log("el color selecionado es negro");
            //        break;
            //    case (int)SeleccionColor.blanco:
            //        Debug.Log("el color seleccionado es blanco");
            //        break;
            //        Debug.Log("el valor es positivo");
            //        break;
        }

        



        
        //    if ((variable1 || variable2) && variable3)
        //    {
        //        Debug.Log("La variable 1 es verdadero");
        //    }
        //    if ((variable1 || variable2) || variable3)
        //    {
        //        if (variable1)
        //        {
        //            Debug.Log("La variable 1 es verdadera");
        //        }
        //        Debug.Log("La operacion 3 es verdadera");
        //    }
        //    if ((variable3 && variable2) || variable1)
        //    {
        //        Debug.Log("la operacion 3 es verdadera");
        //    }
        //}
        //valor1 = Random.Range(limiteInferior, limiteSuperior);
        //Debug.Log(valor1);

        //string resultado = (valor1 >= 1) ? "el valor es positivo" : "el valor es negartivo";
        //Debug.Log(resultado);

        //switch (valor1)
        ////if (valor1 >= 0)
        //{
        //    case (int)SeleccionColor.negro:
        //        Debug.Log("el color selecionado es negro");
        //        break;
        //    case (int)SeleccionColor.blanco:
        //        Debug.Log("el color seleccionado es blanco");
        //        break;
        //        Debug.Log("el valor es positivo");
        //        break; 





        
    }   
}
