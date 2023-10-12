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
        Color color = new Color(Mathf.Sin(t), Mathf.Cos(t), Mathf.Sin(t * 0.7f), 1.0f);
        sphereMaterial.color = color;
    }
}
