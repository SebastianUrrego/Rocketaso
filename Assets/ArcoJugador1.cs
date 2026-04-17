using UnityEngine;

public class ArcoJugador1 : MonoBehaviour
{
    public GameObject Sphere;
    public GameObject JUGADOR1;
    public GameObject JUGADOR2;

    public Transform PuntoBalon;
    public Transform PuntoCarro1;
    public Transform PuntoCarro2;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("ALGO ENTRO A ARCO 1: " + other.name);

        if (other.gameObject == Sphere)
        {
            Debug.Log("? GOL JUGADOR 1");

            Marcador.instancia.GolJugador1();

            Resetear();
        }
    }

    void Resetear()
    {
        // BALON
        Rigidbody rb = Sphere.GetComponent<Rigidbody>();
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        Sphere.transform.position = PuntoBalon.position;

        // CARROS
        JUGADOR1.transform.position = PuntoCarro1.position;
        JUGADOR2.transform.position = PuntoCarro2.position;

        JUGADOR1.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        JUGADOR2.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
    }
}