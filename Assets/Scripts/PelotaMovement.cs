using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelotaMovement : MonoBehaviour
{
    bool ganaste;
    int cantidadDeTiros;

    // Start is called before the first frame update
    void Start()
    {
        ganaste = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles += new Vector3(0, 2.5f, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles -= new Vector3(0, 2.5f, 0);

        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0.1f, 0, 0);
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {

        }

        if (transform.position.y < 0 && cantidadDeTiros <= 10)
        {
            ganaste = true;
        }

        else if (cantidadDeTiros > 10)
        {
            ganaste = false;
        }

        if (ganaste)
        {

        }
        
    }
}
