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
        h = Random.Range(0.0f, 1.0f) > 0.5f ? -1.0f : 1.0f;
        v = Random.Range(0.0f, 1.0f) > 0.5f ? -1.0f : 1.0f;

        float x = Random.Range(-10.0f, 10.0f);
        float y = Random.Range(-5.0f, 5.0f);

        gameObject.transform.position = new Vector2(x, y);

        float r = Random.Range(0.0f, 1.0f);
        float g = Random.Range(0.0f, 1.0f);
        float b = Random.Range(0.0f, 1.0f);
        float alpha = Random.Range(0.5f, 1.0f);
        Color color = new Color(r, g, b, alpha);

        gameObject.GetComponent<Renderer>().material.color = color;

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
