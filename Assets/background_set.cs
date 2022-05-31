using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background_set : MonoBehaviour
{
    // Start is called before the first frame update
    public float background_movespeed = 4.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.down * background_movespeed * Time.deltaTime); //move background
        Vector3 position = this.transform.position;
        if (position.y <= -12.5)
        {
            this.transform.position = new Vector3(position.x, position.y + 15.0f*2 , position.z);
        }
    }
}
