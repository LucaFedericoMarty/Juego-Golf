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
    public  float rotation;
    public float translation;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {           
            isPressing = true;
        }

        if (isPressing == true)
        {
            timeElapsed += Time.deltaTime;
            rotation = horizonatlSpeed * Input.GetAxis("Mouse X");
            translation = Input.GetAxis("Mouse Y")   * timeElapsed;
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            isPressing = false;
            rotation *= Time.deltaTime;
            translation *= Time.deltaTime;
            transform.Rotate(0, rotation, 0);
            transform.Translate(translation, 0, 0);
            rb.AddForce(transform.forward * translation,ForceMode.Impulse);
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
