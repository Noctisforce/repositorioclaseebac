using UnityEngine;

public class GO4 : MonoBehaviour
{
  public static GameObject GO4instancia;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      Debug.Log(GO1.GO1instancia);
        Debug.Log(GO2.GO2instancia);
    }

    // Update is called once per frame
    void Update()
    {
        if (GO1.GO1instancia || GO2.GO2instancia)
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
