using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed;

    void Lerp(float a, float b, float c)
    {
        gameObject.transform.position = new Vector3(transform.position.x + a, transform.position.y - b, transform.position.z + c);
    }

    // Update is called once per frame
    void Update()
    {
        Lerp(Input.GetAxis("Horizontal") * speed, -Input.GetAxis("Vertical") * speed, 0);
        //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }
}
