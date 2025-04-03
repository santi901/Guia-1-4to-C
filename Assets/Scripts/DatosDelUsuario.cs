using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string NombreDeUsuario;
    public int Edad;
    public float Estatura;
    public bool EsDonante;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi Nombre es " + NombreDeUsuario + " tengo " + Edad +
            ", mido " + Estatura + " metros y es " + EsDonante + " que soy donante de órganos.");
    }

    // Update is called once per framex1|
    void Update()
    {
        
    }
}
