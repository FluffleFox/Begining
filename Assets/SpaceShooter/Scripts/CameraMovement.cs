using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    void Update()
    {
        if (player != null)
        {
            Vector3 diff = player.position - transform.position;
            diff.z = 0;
            transform.Translate(diff * 3.0f * Time.deltaTime, Space.World);
        }
    }
}
