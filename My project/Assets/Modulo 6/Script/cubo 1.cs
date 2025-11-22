using UnityEngine;

public class cubo1 : MonoBehaviour
{
    public GameObject cuboPrefab;
    void Awake()
    {
       GameObject cubo1 = Instantiate(cuboPrefab, new Vector3(-4, 0, 8), Quaternion.identity);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
