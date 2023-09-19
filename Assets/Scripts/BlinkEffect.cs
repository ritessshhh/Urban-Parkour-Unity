using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkEffect : MonoBehaviour
{
    public Color startColor = Color.green;
    public Color endColor = Color.black;
    [Range(0, 10)]
    public float speed = 1;

    public int materialIndex = 0;

    Renderer ren;

    void Awake()
    {
        ren = GetComponent<Renderer>();
        //startColor = ren.material.color;
    }

    void Update()
    {
        ren.materials[materialIndex].color = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time * speed, 1));
    }
}
