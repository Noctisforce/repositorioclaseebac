using UnityEngine;

public class Capsulamulticolor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Color Ca = new Color(Random.value, Random.value, Random.value);
         GetComponent<MeshRenderer>().material.color = Ca;
    }
}
