using UnityEngine;

public class GoalDetector : MonoBehaviour
{
    public string nombreArco; // "P1" o "P2"
    public Transform puntoBalon;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGER: " + other.name);

        if (other.name == "Sphere")
        {
            Debug.Log("? GOL en arco: " + nombreArco);

            // Reset balón (prueba mínima)
            other.transform.position = puntoBalon.position;

            Rigidbody rb = other.GetComponent<Rigidbody>();
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
