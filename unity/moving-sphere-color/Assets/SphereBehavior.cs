using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBehavior : MonoBehaviour
{
    private Material sphereMaterial;
    public float radius = 2.0f;
    public float speed = 2.0f;
    private Vector3 centerPosition;
    private float angle = 0.0f;
    private float rRand = 0.5f;
    private float gRand = 0.8f;
    private float bRand = 0.2f;

    void Start()
    {
        centerPosition = transform.position;
        sphereMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        ChangeColor();
        ChangePosition();
    }

    void ChangePosition()
    {
        float x = centerPosition.x + Mathf.Cos(angle) * radius;
        float y = centerPosition.y;
        float z = centerPosition.z + Mathf.Sin(angle) * radius;

        transform.position = new Vector3(x, y, z);
        angle += speed * Time.deltaTime;

        if (angle > Mathf.PI * 2.0f) 
        {
            angle -= Mathf.PI * 2.0f;
        }
    }

    void ChangeColor() 
    {
        float t = Time.time;
        Color color = new Color(Mathf.Sin(t * rRand), Mathf.Cos(t * gRand), Mathf.Sin(t * bRand), 1.0f);
        sphereMaterial.color = color;
    }
}
