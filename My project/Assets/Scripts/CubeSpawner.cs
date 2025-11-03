using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public List<GameObject> listaDeCubos;
    public float FactorDeEscala;
    public int NumeroDeCubos = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        listaDeCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        NumeroDeCubos++;
        GameObject TempGameObject = Instantiate<GameObject>(cubePrefab);
        TempGameObject.name = "CuboNumero" + NumeroDeCubos;
        Color c = new Color(Random.value, Random.value, Random.value);
        TempGameObject.GetComponent<MeshRenderer>().material.color = c;
        TempGameObject.transform.position = Random.insideUnitSphere;

        listaDeCubos.Add(TempGameObject);
        List<GameObject> CubosParaEliminar = new List<GameObject>();
        foreach (GameObject go in listaDeCubos)
        {
            float scale = go.transform.localScale.x;
            scale *= FactorDeEscala;
            go.transform.localScale = Vector3.one * scale;
            
            if (scale <= 0.1)
            {
                CubosParaEliminar.Add(go);
            }    
        }

        foreach (GameObject go in CubosParaEliminar)
        {
            listaDeCubos.Remove(go);
            Destroy(go);
        }
    }

}
