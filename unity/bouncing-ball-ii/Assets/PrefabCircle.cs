using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabCircle : MonoBehaviour
{
    public GameObject circle;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i ++) {
            Instantiate(circle, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
