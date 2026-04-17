using UnityEngine;

public class Car1Movement : MonoBehaviour
{
    public float velocidad = 10f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontal = 0f;
        float vertical = 0f;

        // WASD manual
        if (Input.GetKey(KeyCode.A)) horizontal = 1f;
        if (Input.GetKey(KeyCode.D)) horizontal = -1f;
        if (Input.GetKey(KeyCode.W)) vertical = -1f;
        if (Input.GetKey(KeyCode.S)) vertical = 1f;

        Vector3 movimiento = new Vector3(horizontal, 0f, vertical);

        rb.MovePosition(rb.position + movimiento * velocidad * Time.fixedDeltaTime);
    }
}