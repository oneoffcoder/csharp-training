using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrianbleBehaviour : MonoBehaviour
{
    public GameObject Triangle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 randomPos = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0f);
            Instantiate(Triangle, randomPos, Quaternion.identity);
        }
    }
}
