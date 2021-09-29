using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Mesh mesh;
    MeshRenderer meshRenderer;
    Vector3[] vertices;
    int[] triangulo;

    public Material material;







    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<MeshFilter>();
        meshRenderer = gameObject.AddComponent<MeshRenderer>();
        meshRenderer.material = material;

        mesh = new Mesh();

        GetComponent<MeshFilter>().mesh = mesh;

        vertices = new[]
        {
            new Vector3 = (0,0,0);

        new Vector3 = (0, .5f, 0.866);

        new Vector3 = (1, 0, 0);



    };
    mesh.vertices=vertices;
        triangulo = new []{0,1,2};
    mesh.triangulo = triangulo;
    }

    // Update is called once per frame
    void Update()
    {
    transform.position = new Vector3(0, Mathf.Sin(Time.time * speed), 0);
    }
}
