using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipFlying : MonoBehaviour
{
    private float speed;
    private float turnSpeed;

    private GetInputs Input;
    
    private float lastThrust = float.MinValue;



    void Awake()
    {
        Input = GetComponent<GetInputs>();
        this.speed = gameObject.GetComponent<Ship>().speed;
        this.turnSpeed = gameObject.GetComponent<Ship>().turnSpeed;
    }

    // Update is called once per frame
    void Update()
    {

        lastThrust = Input.Vertical;

        transform.position += Time.deltaTime * Input.Vertical * transform.forward * speed;
        transform.Rotate(Vector3.up * Input.Horizontal * turnSpeed * Time.deltaTime);
    }
}
