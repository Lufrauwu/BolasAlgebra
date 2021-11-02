using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspacioVectorial : MonoBehaviour
{
    // Start is called before the first frame update

    public float distancia;
    public GameObject player;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        distancia = Vector3.Distance(player.transform.position, transform.position);
        if(distancia<2.2f)
        {
            player.GetComponent<Renderer>().material.color = Color.red;
            Debug.Log("A si xd");
        }
        else 
        {
            player.GetComponent<Renderer>().material.color = Color.green;
            Debug.Log("jelou aim ondeer de guater");
        }
    }
}