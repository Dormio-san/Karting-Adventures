using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorModifier : MonoBehaviour
{
    public MeshRenderer mat;
    public Slider red;
    public Slider green;
    public Slider blue;


    public void OnEdit()
    {
        Color color = mat.material.color;
        color.r = red.value;
        color.g = green.value;
        color.b = blue.value;
        mat.material.color = color;
        mat.material.SetColor("_EmissionColor", color);
    }
}
