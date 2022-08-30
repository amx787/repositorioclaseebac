using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{

    int x;

    // Start is called before the first frame update
    void Start()
    {

        x = 0;
        print("algo paso");

        Debug.LogWarning("Algo salio Medianamente Mal");
        Debug.LogError("Algo Salio Muy Mal");
    }

    // Update is called once per frame
    void Update()
    {
        //x++;
        //Debug.Log(x);
        Debug.Log("Hola desde Update");  
    }
    private void FixedUpdate() 
    {
        Debug.LogWarning("hola desde Fixed Update cada 50 frames");      
    } 
    private void LateUpdate()
    {
        Debug.Log("hola desde Late Update");  
    }
    private void OnEnable()
    {
        Debug.LogWarning("el objeto ha sido habilitado");  
    }
    private void OnDisable()
    {
        Debug.LogWarning("el objeto ha sido inhabilitado");  
    }

}
