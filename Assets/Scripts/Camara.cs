using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject astronaut;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = astronaut.transform.position + offset;
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0,-1,0 *Time.deltaTime * 1);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0,1,0 *Time.deltaTime * 1);
        }
    }
}