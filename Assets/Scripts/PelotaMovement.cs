using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelotaMovement : MonoBehaviour
{
    //Variable Bool
    bool ganaste;
    bool isPressing;

    // Variables Int
    int cantidadDeTiros;

    // Variable Float
    float timeElapsed;
    float horizonatlSpeed = 2.0f;
    float rotation;
    float translation;

    // Start is called before the first frame update
    void Start()
    {
        isPressing = false;
        ganaste = true;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.eulerAngles += new Vector3(0, 2.5f, 0);
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.eulerAngles -= new Vector3(0, 2.5f, 0);

        //}

        //if (Input.GetKey(KeyCode.Space))
        //{
        //    transform.Translate(0.1f, 0, 0);
        //}

        if (isPressing == false)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                timeElapsed += Time.deltaTime;
                rotation = horizonatlSpeed * Input.GetAxis("Mouse Y");
                translation = Input.GetAxis("Mouse X") * timeElapsed;
                isPressing = true;
            }
        }

        if (isPressing)
        {
            rotation *= Time.deltaTime;
            translation *= Time.deltaTime;
            transform.Rotate(0, rotation, 0);
            transform.Translate(translation, 0, 0);
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
