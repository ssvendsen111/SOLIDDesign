using System;
using UnityEngine;

public class GetInputs : MonoBehaviour
{
    public float Horizontal { get; set; }
    public float Vertical { get; set; }

    private ShootProjectile sp;
    public Ship[] shipArray;
    private int shipIndex = 0;


    private void Awake()
    {
        sp = GetComponent<ShootProjectile>();
    }
    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        if (Input.GetButtonDown("Fire1"))
        {
            sp.Shoot();

        }
        /*if (Input.GetKeyDown(KeyCode.Alpha1)) {
            gameObject.SetActive(false);
            shipIndex++;
            //gameObject.SetActive(true);

            Debug.Log(shipIndex);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //ss.selectShip(1);
            //Debug.Log("Ship2");
        }*/
    }
}
