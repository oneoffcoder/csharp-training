using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleBehaviourScript : MonoBehaviour
{
    public float speed = 0.005f;
    float h = 1.0f;
    float v = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-10.0f, 10.0f);
        float y = Random.Range(-5.0f, 5.0f);
        gameObject.transform.position = new Vector2(x, y);

        Debug.Log($"{Screen.width}, {Screen.height}");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        if (pos.x < 0.0 || pos.x > 1.0)
        {
            Debug.Log("left-right edge");
            h *= -1;
        }
        else if (pos.y < 0.0 || pos.y > 1.0)
        {
            Debug.Log("top-bottom edge");
            v *= -1;
        }

        float x = transform.position.x + (h * speed);
        float y = transform.position.y + (v * speed);

        gameObject.transform.position = new Vector2(x, y);
    }
}
