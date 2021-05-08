using UnityEngine;

public class Bird : MonoBehaviour
{
    Rigidbody rb;
    public float force = 5;
    int score = 0;
    public UI display;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
        transform.GetChild(0).rotation = Quaternion.Euler(0, 0, Mathf.Atan2(rb.velocity.y, 2) * Mathf.Rad2Deg);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("GameOver score: "+score);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        score++;
        display.UpdateScore(score);
    }
}
