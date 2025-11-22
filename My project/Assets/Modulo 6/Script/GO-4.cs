using UnityEngine;

public class GO4 : MonoBehaviour
{
    bool GO1;
    bool GO2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      GO1 = true;
        GO2 = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (GO1 || GO2)
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
