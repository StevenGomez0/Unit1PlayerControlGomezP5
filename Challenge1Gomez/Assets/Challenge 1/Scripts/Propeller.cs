using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    public float spin;
    // Update is called once per frame
    void Update()
    {
        //spins propeller at a constant rate on z axis
        transform.Rotate(0, 0, 90 * spin * Time.deltaTime);
    }
}
