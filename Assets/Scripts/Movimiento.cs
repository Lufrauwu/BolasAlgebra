using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private int speeed = 3;

    private float timer = 0;
    public GameObject camera1;
    public GameObject camera2;
    // Start is called before the first frame update
    void Start()
    {
        camera1.SetActive(true);
        camera2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 2);

        }

        if (Input.GetKey(KeyCode.Q))
        {
          transform.Rotate(0,-1,0 *Time.deltaTime * 2);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0,1,0 *Time.deltaTime * 2);
        }

        if (Input.GetKey(KeyCode.V))
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
        if (Input.GetKey(KeyCode.C))
        {
            camera1.SetActive(true);
            camera2.SetActive(false);
        }


        if (timer<=2)
        {
         subida();

        }

        if (timer>=2)
        {
          bajada();
          if (timer>=4)
          {
              timer = 0;
          }
        }



    }

    void subida()
    {
      this.transform.Translate(Vector3.up * Time.deltaTime * 1);

    }

    void bajada()
    {
        transform.Translate(Vector3.down * Time.deltaTime * 1);
    }
}