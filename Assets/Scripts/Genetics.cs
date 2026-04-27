using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genetics : MonoBehaviour
{
    public enum Shapes { Square, Sphere, Cylinder };

    [Header("Genes")]
    public Color color_1;
    public Color color_2;
    
    public Shapes shape_1;
    public Shapes shape_2;
}
