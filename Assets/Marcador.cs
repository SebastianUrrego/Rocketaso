using UnityEngine;
using TMPro;

public class Marcador : MonoBehaviour
{
    public static Marcador instancia;

    public int golesJugador1 = 0;
    public int golesJugador2 = 0;

    public TextMeshProUGUI textoMarcador;

    void Awake()
    {
        instancia = this;
    }

    void Start()
    {
        ActualizarUI();
    }

    public void GolJugador1()
    {
        golesJugador1++;
        ActualizarUI();
    }

    public void GolJugador2()
    {
        golesJugador2++;
        ActualizarUI();
    }

    void ActualizarUI()
    {
        textoMarcador.text = "P1: " + golesJugador1 + "  |  P2: " + golesJugador2;
    }
}