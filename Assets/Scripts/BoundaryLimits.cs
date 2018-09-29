using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryLimits: MonoBehaviour
{
    public Camera cam;
    public float largura, altura;
    private EdgeCollider2D colisor;
    public List<Vector2> vertices = new List<Vector2>();

    // Use this for initialization
    void Start()
    {
        colisor = GetComponent<EdgeCollider2D>();
        altura = cam.orthographicSize;
        largura = altura * cam.aspect;

        vertices.Add(new Vector2(largura + 1, altura + 1));
        vertices.Add(new Vector2(-largura - 1, altura + 1));
        vertices.Add(new Vector2(-largura - 1, -altura - 1));
        vertices.Add(new Vector2(largura + 1, -altura - 1));
        vertices.Add(new Vector2(largura + 1, altura + 1));
    }

    // Update is called once per frame
    void Update()
    {
        colisor.points = vertices.ToArray();
    }
}
