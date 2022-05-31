using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 move;
    public GameObject player , role;
    public float x_max, x_min, y_max, y_min;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(
                                                Mathf.Clamp(transform.position.x, x_min, x_max),
                                                Mathf.Clamp(transform.position.y, y_min, y_max),
                                                1
                                                );


        if (Input.GetMouseButton(0))
        {
            move = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            move.z = 0;
            player.transform.position = move;
            role.transform.parent = player.transform;
            if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0) 
            {
                
                player.transform.position = move ;
            }
        }
        else
        {
            player.transform.DetachChildren();
        }
        
        
    }
}
