using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager2 : MonoBehaviour
{
    public GameObject Vehicle;
    private bool switched = false;
    public GameObject first;
    public GameObject second;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            if (switched == false)
            {
                first.SetActive(false);
                second.SetActive(true);
                switched = true;
            }

            else
            {
                first.SetActive(true);
                second.SetActive(false);
                switched = false;
            }
        }
    }
}
