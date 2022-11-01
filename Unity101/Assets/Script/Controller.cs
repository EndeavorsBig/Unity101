using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //print(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        //print("Hello");
        if (Input.GetKey(KeyCode.W))
            {
            //print("w");
            transform.position = new Vector3(transform.position.x , transform.position.y + 0.01f, 0);
        } else

        if (Input.GetKey(KeyCode.S))
        {
            //print("w");
            transform.position = new Vector3( transform.position.x , transform.position.y - 0.01f, 0);

        } else

            if (Input.GetKey(KeyCode.A))
        {
            //print("w");
            transform.position = new Vector3(transform.position.x - 0.01f , transform.position.y, 0);
        } else
            if (Input.GetKey(KeyCode.D))
        {
            //print("w");
            transform.position = new Vector3(transform.position.x + 0.01f, transform.position.y, 0);
        }
    }
}
