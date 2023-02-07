using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaM7Bool : MonoBehaviour
{

    bool variable1;
    bool variable2;
    int valor1 = 2;
    int limiteInferior = 0;
    int limiteSuperior = 1;
    
    enum SelecionColor
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
        if (variable1 || variable2)
        {
            Debug.Log("La variable 1 es verdadero");  
        }
        valor1 = Random.Range(limiteInferior, limiteSuperior);
        Debug.Log(valor1);
        if (valor1 >= 0)
        {
            Debug.Log("el valor es positivo");
                
        }
            
    } 
}
