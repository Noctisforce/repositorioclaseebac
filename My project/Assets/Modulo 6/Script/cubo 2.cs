using UnityEngine;

public class cubo2 : MonoBehaviour
{
    GameObject Cubo2;
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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cubo2 = new GameObject("Cubo2");
        Cubo2.AddComponent<MeshFilter>();
        var mesh = Cubo2.GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.Optimize();
        mesh.RecalculateNormals();
        Cubo2.AddComponent<BoxCollider>();
        var boxCollider = Cubo2.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        Cubo2.AddComponent<MeshRenderer>();
        var renderer = Cubo2.GetComponent<MeshRenderer>().material;
        renderer.color = Color.yellow;
        Cubo2.transform.position = Vector3.one;
    }
}
