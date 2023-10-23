using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipSwitching : MonoBehaviour
{
    public int selectedShip = 0;
    // Start is called before the first frame update
    void Start()
    {
        selectShip(selectedShip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selectShip(int input)
    {
        int i = input;
        foreach (Transform ship in transform) {
            if (i == selectedShip)
            {
                ship.gameObject.SetActive(true);
            }
            else {
                ship.gameObject.SetActive(false);
            }

            i++;
        }
    }
}
