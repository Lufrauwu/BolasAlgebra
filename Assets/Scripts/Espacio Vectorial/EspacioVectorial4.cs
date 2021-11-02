using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspacioVectorial4 : MonoBehaviour
{
    // Start is called before the first frame update

    public float distancia;
    public GameObject player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distancia = Vector3.Distance(player.transform.position, transform.position);
        if(distancia<=2.2f)
        {
            player.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log("A si xd");
        }
        else 
        {
            player.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }
}
