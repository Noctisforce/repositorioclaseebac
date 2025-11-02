using UnityEngine;

public class cubo1 : MonoBehaviour
{
    GameObject Cubo1;
    Vector3[] vertices =
    {
        new Vector3(0,0,0),
        new Vector3(1,0,0),
        new Vector3(1,1,0),
        new Vector3(0,1,0),
        new Vector3(0,1,1),
        new Vector3(1,1,1),
        new Vector3(1,0,1),
        new Vector3(0,0,1),
    };

    int[] triangles =
    {
        0,2,1,
        0,3,2,
        2,3,4,
        2,4,5,
        1,2,5,
        1,5,6,
        0,7,4,
        0,4,3,
        5,4,7,
        5,7,6,
        0,6,7,
        0,1,6
    };

    void Awake()
    {
        Cubo1 = new GameObject("Cubo1");
        Cubo1.AddComponent<MeshFilter>();
        var mesh = Cubo1.GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.Optimize();
        mesh.RecalculateNormals();
        Cubo1.AddComponent<BoxCollider>();
        var boxCollider = Cubo1.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        Cubo1.AddComponent<MeshRenderer>();
        var renderer = Cubo1.GetComponent<MeshRenderer>().material;
        renderer.color = Color.red;
        Cubo1.transform.position = new Vector3(-5,1,1);
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
