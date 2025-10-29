using UnityEngine;

public class HOLAmundo : MonoBehaviour
{
<<<<<<< Updated upstream
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       print("Hola mundo");
        Debug.Log("algo paso");
=======
   void Awake()
    {
        Debug.Log("Hola desde Awake");
    }
    int x;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       x = 0;
        print("Hola mundo");
       
>>>>>>> Stashed changes
        Debug.LogWarning("algo salio medianamente mal");
        Debug.LogError("algo salio muy mal");
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        
=======
        //x = x + 1;
        //Debug.Log(x);

        Debug.Log("Hola desde Update");
    }
    void FixedUpdate()
    {
        Debug.LogWarning("Hola desde FixedUpdate cada 50 frame");
    }
    void LateUpdate()
    {
        Debug.Log("Hola desde LateUpdate");
    }
    private void OnEnable()
    {
        Debug.LogWarning("El objeto se ha activado");
    }
    private void OnDisable()
    {
        Debug.LogWarning("El objeto se ha desactivado");
>>>>>>> Stashed changes
    }
}
