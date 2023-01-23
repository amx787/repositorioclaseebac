using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funcionOnEnable : MonoBehaviour
{
    public GameObject PrefabCubo;
    public List<GameObject> listaDeCubos;
    public float factordeEscalamiento;
    public int numCubos = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        GameObject temGameObjet = Instantiate<GameObject>(PrefabCubo);
        Color c = new Color(Random.value, Random.value, Random.value);
        temGameObjet.GetComponent<MeshRenderer>().material.color = c;  
    }
}
