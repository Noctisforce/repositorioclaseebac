using UnityEngine;

public class Esferamulticolor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Color Es = new Color(Random.value, Random.value, Random.value);
        GetComponent<MeshRenderer>().material.color = Es;
    }
}

