using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traffic : MonoBehaviour
{
    public float trafficSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //moves oncoming vehicles forward
        transform.Translate(Vector3.forward * Time.deltaTime * trafficSpeed);
    }
}
