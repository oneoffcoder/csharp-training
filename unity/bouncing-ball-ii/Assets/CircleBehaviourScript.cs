using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleBehaviourScript : MonoBehaviour
{
    public GameObject circle;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i ++) {
            float x = Random.Range(-10.0f, 10.0f);
            float y = Random.Range(-5.0f, 5.0f);
            float z = 0.0f;

            Debug.Log($"x={x}, y={y}, z={z}");
            
            // Instantiate(circle, new Vector3(x, y, z), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
