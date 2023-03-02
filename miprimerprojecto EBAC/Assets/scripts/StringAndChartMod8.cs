using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringAndChartMod8 : MonoBehaviour
{
    string miNombre = "isaac colin soto";
    string miString = "el valor de este estring";
    float numero = 123456;
    char miLetra1;
    char miLetra2;
    char miLetra3;
    char miLetra4;
    string prueba = "Hola Mundo";

    Color w = Color.white;
    Color b = Color.black;  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log(prueba);
        char p1 = prueba[0];
        char p2 = prueba[2];
        char p3 = prueba[6];
        char p4 = prueba[8];
        Debug.Log(p1);
        Debug.Log(p2);
        Debug.Log(p3);
        Debug.Log(p4);
        char[] delimitador = { ' ' };
        string[] trozos = prueba.Split(delimitador);
        int i;
        for (i = 0; i <trozos.Length; i++)
        {
            Debug.LogFormat("Fragmento {0} = {1}", (1+1), trozos[i]);
        }
        
        Debug.Log(prueba[^6..]); 
    }
    private void FixedUpdate()
    {
      
        

        switch (miString)
        {
            case "el valor de este estring":
                Debug.Log("el valor es de 23 chart");
                GetComponent<MeshRenderer>().material.color = b;
                break;
                        

        }

        string mistring = numero.ToString();
        Debug.Log(numero);
        miLetra1 = mistring[1];  /*tomo en cuata el valor 1 sabiendo que imprimiria el 2 el valor sero seria el 1 */
        miLetra2 = mistring[2];
        miLetra3 = mistring[3];
        miLetra4 = mistring[4];
        Debug.Log(miLetra1);
        Debug.Log(miLetra2);
        Debug.Log(miLetra3);
        Debug.Log(miLetra4);
        

        string nombreCompleto1 = miNombre.Substring(0,5);
        Debug.Log(nombreCompleto1); 
        string nombreCompleto2 = miNombre.Substring(0, 12);
        Debug.Log(nombreCompleto2);
        string nombreCompleto3 = miNombre.Substring(0, 16);
        Debug.Log(nombreCompleto3);

        char[] delimitador = { ',', ' ' };
        string[] secciones = miNombre.Split(delimitador);
        int i;
        for (i = 0; i <secciones.Length; i++) 
        {
            Debug.LogFormat("Fragmento {0} = {1}", (i + 1), secciones [i]);  

        }
        bool resulado1;
        string vnumero1 = "1299";
        string vnumero2 = "1701";
        int entero1 = int.Parse(vnumero1);
        int entero2 = int.Parse(vnumero2);
        
        var valido1 = int.TryParse("1299",out entero1);
        var valido2 = int.TryParse("1701", out entero2);
        if (valido1  || valido2 )
        {
            resulado1  = true;
            Debug.Log(resulado1); 
        }
        else
        {
            resulado1 = false;
            Debug.Log(resulado1);


        }
    }
}
