using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemaUno : MonoBehaviour
{
    public float Dinero;
    public string Moneda;


    float MonedaConvertida;
    float MontoMinimo = 1000;
    float CotisacionMonedaElegida;
    float Dolar = 1345f;
    float Euro = 936.2f;
    float Real = 173.3f;


    // Start is called before the first frame update
    void Start()
    {
        if (Dinero < MontoMinimo)
        {
            Debug.Log("El monto es menor a 1000");
            return;
        }
        if (Moneda == "D")
        {
            CotisacionMonedaElegida = Dolar;
        }
        else if (Moneda == "E")
        {
            CotisacionMonedaElegida = Euro;
        }
        else if (Moneda == "R")
        {
            CotisacionMonedaElegida = Real;
        }
        else
        {
            Debug.Log("Opción de moneda extranjera no válida");
            return;
        }
        

        Dinero = Dinero / CotisacionMonedaElegida;

        Debug.Log(Dinero);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
