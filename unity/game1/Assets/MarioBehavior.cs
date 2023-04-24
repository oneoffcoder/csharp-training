using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioBehavior : MonoBehaviour
{
    public float speed;
    public Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        // float x = transform.position.x + (h * speed);
        // float y = transform.position.y + (v * speed);
        // gameObject.transform.position = new Vector2(x, y);
        float x = (h * speed);
        float y = (v * speed);
        body.velocity = new Vector2(x, y);
    }
}
