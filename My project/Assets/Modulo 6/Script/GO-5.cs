using UnityEngine;

public class GO5 : MonoBehaviour
{
    bool GO3;
    bool GO4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        GO3 = false;
        GO4 = true;


    }

    // Update is called once per frame
    void Update()
    {
         if (GO3 && GO3)
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
