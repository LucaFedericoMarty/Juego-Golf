using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuardarTirosPasarEscena : MonoBehaviour
{
    public Text cantidadTiros;
    public Text mensajeDeError;

    public void guardarCantidadDeTiros()
    {
        int numeroDeTiros = int.Parse(cantidadTiros.text);

        if (cantidadTiros.text == "")
        {
            mensajeDeError.text = "El campo no puede estar vacio";
        }

        else if (numeroDeTiros >= 30)
        {
            mensajeDeError.text = "Los tiros no pueden ser mas de 30";
        }



    }
}
