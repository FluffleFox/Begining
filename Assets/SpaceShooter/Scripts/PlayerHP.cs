using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("dupa");
        if (collision.gameObject.GetComponent<Metaor>() != null)
        {
            Destroy(gameObject);
        }
    }
}
