using UnityEngine;

public class cubo2 : MonoBehaviour
{
    public GameObject cuboPrefabs2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(cuboPrefabs2, new Vector3(0, 0, 8), Quaternion.identity);
    }
}
