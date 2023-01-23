using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funcionAwake : MonoBehaviour
{
    public GameObject PrefabCubo;
    public List<GameObject> listaDeCubos;
    private void Awake()
    {
        GameObject temGameObjet = Instantiate<GameObject>(PrefabCubo);
        Color c = new Color(Random.value, Random.value, Random.value);
        temGameObjet.GetComponent<MeshRenderer>().material.color = c;

        
        

        
    }
}
