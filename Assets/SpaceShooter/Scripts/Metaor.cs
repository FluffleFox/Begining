using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metaor : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized, ForceMode2D.Impulse);
    }

    void Hit()
    {
        if (transform.localScale.x >= 0.5f)
        {
            GameObject go = (GameObject)Instantiate(gameObject, transform.position, Quaternion.identity);
            go.transform.localScale = transform.localScale * 0.5f;
            go = (GameObject)Instantiate(gameObject, transform.position, Quaternion.identity);
            go.transform.localScale = transform.localScale * 0.5f;
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
