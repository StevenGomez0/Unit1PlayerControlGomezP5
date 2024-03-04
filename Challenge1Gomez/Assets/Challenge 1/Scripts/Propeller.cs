using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    public float spin;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 2 * spin * Time.deltaTime);
    }
}
