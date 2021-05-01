using UnityEngine;

public class Pipe : MonoBehaviour
{
    Vector3 left;
    void Start()
    {
        left = Vector3.left;
        LosujPozycje();
    }


    void Update()
    {
        transform.Translate(left * Time.deltaTime, Space.World);
        if (transform.position.x < -8.0f)
        {
            LosujPozycje();
            transform.position = new Vector3(16, transform.position.y, transform.position.z);
        }
    }

    void LosujPozycje()
    {
        transform.position = new Vector3(transform.position.x, Random.Range(-2.0f, 2.0f), transform.position.z);

    }
}
