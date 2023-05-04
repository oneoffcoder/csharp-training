using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class CircleBehaviourScript : MonoBehaviour
{
    private Camera _camera;
    public float speed = 0.005f;
    private float _h = 1.0f;
    private float _v = 1.0f;
    private bool _flip = false;
    
    void Start()
    {
        _camera = Camera.main;
        _h = Random.Range(0.0f, 1.0f) > 0.5f ? -1.0f : 1.0f;
        _v = Random.Range(0.0f, 1.0f) > 0.5f ? -1.0f : 1.0f;

        var x = Random.Range(-10.0f, 10.0f);
        var y = Random.Range(-5.0f, 5.0f);

        gameObject.transform.position = new Vector2(x, y);

        var r = Random.Range(0.0f, 1.0f);
        var g = Random.Range(0.0f, 1.0f);
        var b = Random.Range(0.0f, 1.0f);
        var alpha = Random.Range(0.5f, 1.0f);
        var color = new Color(r, g, b, alpha);

        gameObject.GetComponent<Renderer>().material.color = color;

        // Debug.Log($"{Screen.width}, {Screen.height}");
    }

    // Update is called once per frame
    void Update()
    {
        if (_camera is null)
        {
            return;
        }
        var pos = _camera.WorldToViewportPoint(transform.position);
        if (pos.x < 0.0 || pos.x > 1.0 || _flip)
        {
            // Debug.Log("left-right edge");
            _h *= -1;
        }
        else if (pos.y < 0.0 || pos.y > 1.0 || _flip)
        {
            // Debug.Log("top-bottom edge");
            _v *= -1;
        }

        if (_flip)
        {
            _flip = false;
        }

        var position = transform.position;
        var x = position.x + (_h * speed);
        var y = position.y + (_v * speed);

        gameObject.transform.position = new Vector2(x, y);
    }

    private void Flip()
    {
        _flip = true;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.collider.CompareTag("Circle")) 
            return;

        var that = collision.collider.GetComponent<CircleBehaviourScript>();
        that.Flip();
        this.Flip();
    }
}
