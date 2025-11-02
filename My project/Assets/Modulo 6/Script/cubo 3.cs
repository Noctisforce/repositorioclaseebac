using UnityEngine;

public class cubo3 : MonoBehaviour
{
    GameObject Cubo3;
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
        
    }

    private void OnDisable()
    {
        Cubo3 = new GameObject("Cubo3");
        Cubo3.AddComponent<MeshFilter>();
        var mesh = Cubo3.GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.Optimize();
        mesh.RecalculateNormals();
        Cubo3.AddComponent<BoxCollider>();
        var boxCollider = Cubo3.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        Cubo3.AddComponent<MeshRenderer>();
        var renderer = Cubo3.GetComponent<MeshRenderer>().material;
        renderer.color = Color.blue;
        Cubo3.transform.position = new Vector3(6, 1, 1);

    }
    private void OnEnable()
    {
        Cubo3 = GameObject.Find("Cubo3");
        Cubo3.AddComponent<MeshRenderer>();
        var mesh= Cubo3.GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.Optimize();
        mesh.RecalculateNormals();
        Cubo3.AddComponent<BoxCollider>();
        var boxCollider = Cubo3.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        Cubo3.AddComponent<MeshRenderer>();
        var renderer = Cubo3.GetComponent<MeshRenderer>().material;
        renderer.color = Color.green;
        Cubo3.transform.position = new Vector3(4, 1, 1);
    }
}
