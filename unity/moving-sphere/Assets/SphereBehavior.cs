using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBehavior : MonoBehaviour
{
    public float radius = 2.0f;
    public float speed = 2.0f;
    private Vector3 centerPosition;
    private float angle = 0.0f;

    void Start()
    {
        centerPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
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
}
