using UnityEngine;

public class Car2movement : MonoBehaviour
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

        // Flechas
        if (Input.GetKey(KeyCode.LeftArrow)) horizontal = -1f;
        if (Input.GetKey(KeyCode.RightArrow)) horizontal = 1f;
        if (Input.GetKey(KeyCode.UpArrow)) vertical = 1f;
        if (Input.GetKey(KeyCode.DownArrow)) vertical = -1f;

        Vector3 movimiento = new Vector3(horizontal, 0f, vertical);

        rb.MovePosition(rb.position + movimiento * velocidad * Time.fixedDeltaTime);
    }
}