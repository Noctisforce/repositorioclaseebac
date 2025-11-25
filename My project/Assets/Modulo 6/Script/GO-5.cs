using UnityEngine;

public class GO5 : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log(GO3.GO3instancia);
        Debug.Log(GO4.GO4instancia);


    }

    // Update is called once per frame
    void Update()
    {
         if (GO3.GO3instancia || GO4.GO4instancia)
        {
            Color VERDADERO = Color.white;
            GetComponent<MeshRenderer>().material.color = VERDADERO;
        }
        else
        {
            Color FALSO = Color.black;
            GetComponent<MeshRenderer>().material.color = FALSO;
        }
    }
}
