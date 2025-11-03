using UnityEngine;

public class cubo3 : MonoBehaviour
{
   public GameObject cuboPrefabs3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
       Instantiate(cuboPrefabs3, new Vector3(4, 0, 8), Quaternion.identity);

    }
    private void OnEnable()
    {
       Instantiate(cuboPrefabs3, new Vector3(4, 0, 8), Quaternion.identity);
    }
}
