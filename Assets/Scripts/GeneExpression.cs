using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class GeneExpression : MonoBehaviour
{
    public GameObject body;
    public Genetics genes;


    Dictionary<string, PrimitiveType> bodyRender = new Dictionary<string, PrimitiveType>() 
    {
        { "Square", PrimitiveType.Cube },
        { "Sphere", PrimitiveType.Sphere },
        { "Cylinder", PrimitiveType.Cylinder }
    };

    public bool resetShape;
    void Start()
    {
        body = gameObject;
        genes = GetComponent<Genetics>();
    }

    void Update()
    {
        var objRenderer = body.GetComponent<Renderer>();

        //Color
        UnityEngine.Color lerped = UnityEngine.Color.Lerp(genes.color_1, genes.color_2, 0.5f);
        objRenderer.material.SetColor("_BaseColor", lerped);

        //Shape
        if (resetShape)
        {
            GameObject temp = GameObject.CreatePrimitive(bodyRender[body.GetComponent<Genetics>().shape_1.ToString()]);

            body.GetComponent<MeshFilter>().mesh = temp.GetComponent<MeshFilter>().sharedMesh;
            
            body.AddComponent<BoxCollider>();

            Destroy(temp);
            resetShape = false;
        }

    }
}
