using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funcionFixedupdate : MonoBehaviour
{
    public GameObject PrefabCubo;
    public List<GameObject> listaDeCubos;
   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GameObject temGameObjet = Instantiate<GameObject>(PrefabCubo);
        Color c = new Color(Random.value, Random.value, Random.value);
        temGameObjet.GetComponent<MeshRenderer>().material.color = c;
    }
}
