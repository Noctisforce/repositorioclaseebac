using UnityEngine;

public class GO2: MonoBehaviour
{
   
    public static bool estado;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        estado = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (estado = !estado)
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
