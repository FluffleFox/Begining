using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    void Start()
    {
        Invoke("End", 7);
    }
    void Update()
    {
        transform.Translate(transform.up * speed * Time.deltaTime, Space.World);
    }

    void End()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.collider.gameObject.SendMessage("Hit");
        End();
    }
}
