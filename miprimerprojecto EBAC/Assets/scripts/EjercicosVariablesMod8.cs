using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicosVariablesMod8 : MonoBehaviour
{
    int miShort = 3;
    double miDouble = 3.5;
    int miInt;
    
    
    Color w = Color.white;
    Color b = Color.black;  
        

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        miShort *= 2;
        Debug.Log("valor de mi entero" + miShort);   
    }
    void FixedUpdate()
    {
        miDouble *= 3;
        Debug.Log("valor de mi float" + miDouble);
        
        
        double a = 12.3;
        double b = 12.4;
        double  c = a + b;
        int resutaldo1 = (int)c;
        Debug.Log("valor de resultado1 "  + resutaldo1);

        int a1 = 5, b1 = 10;
       
        miInt = Random.Range(a1, b1);

        if  (miInt % 2 == 0)
        {
            Debug.Log("el numero" + miInt + "es par");
            GetComponent<MeshRenderer>().material.color = w;  
        } 
        else 
        {
            Debug.Log("el numero" + miInt + "es non ");
            GetComponent<MeshRenderer>().material.color = Color.black;  
            
        } 
     
    }
}
