using UnityEngine;

public class GO5 : MonoBehaviour
{
    public static bool estado;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
         if (GO3.estado || GO4.estado)
        {
            Color VERDADERO = Color.white;
            GetComponent<MeshRenderer>().material.color = VERDADERO;
            estado = true;
        }
        else
        {
            Color FALSO = Color.black;
            GetComponent<MeshRenderer>().material.color = FALSO;
            estado = false;
        }
    }
}
