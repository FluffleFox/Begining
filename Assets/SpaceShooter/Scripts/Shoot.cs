using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float reloadDruation = 1.0f;
    float reload = 0.0f;
    void Update()
    {
        //reload -= Time.deltaTime;
        reload = reload - Time.deltaTime;
        //reload = -0.002
        if (Input.GetMouseButton(0) && reload <= 0.0f)
        {
            Instantiate(bullet, transform.position + transform.up * 0.3f, transform.rotation);
            reload = reloadDruation;
            //reload = 1;
        }
        //tą która ma dostać nową wartość = nową wartość;
    }
}
