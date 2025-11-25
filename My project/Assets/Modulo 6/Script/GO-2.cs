using UnityEngine;

public class GO2: MonoBehaviour
{
   public static GameObject GO2instancia;
    bool state;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        state = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (state = !state)
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
