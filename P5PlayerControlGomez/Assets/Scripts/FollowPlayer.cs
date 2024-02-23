using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset = new Vector3(0, 5, -7);
    private bool cameraChange = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (cameraChange == true)
        {

        }
        // offset the camera behind the player by adding to the player's position
        transform.position = Player.transform.position + offset;

        if (Input.GetKey(KeyCode.Space))
        {
            offset = new Vector3(0, 3, 3);
        }
       
       
    }

}
