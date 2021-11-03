using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspacioVectorial : MonoBehaviour
{
    // Start is called before the first frame update

    public float distancia;
    public GameObject player;
    GameObject[] ObstacleList = new GameObject[2];

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distancia = Vector3.Distance(player.transform.position, transform.position);
        if(distancia<=2.4f)
        {
            ObstacleList = GameObject.FindGameObjectsWithTag("Obstacle");
            //print(ObstacleList.Length);
            foreach (GameObject p in ObstacleList)
            {
                float distancep = Vector3.Distance(p.transform.position, transform.position);
                //print( "p "+ p.transform.position + "yo" +transform.position);
                if (p.transform.position==transform.position)
                {
                    p.GetComponent<MeshRenderer>().enabled = true;
                }
                if (distancia <= 1.0f)
                {
                    p.GetComponent<MeshRenderer>().enabled = false;
                }
            }
        }
        else 
        {
            player.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            ObstacleList = GameObject.FindGameObjectsWithTag("Obstacle");
            //print(ObstacleList.Length);
            foreach (GameObject p in ObstacleList)
            {
                float distancep = Vector3.Distance(p.transform.position, transform.position);
                //print( "p "+ p.transform.position + "yo" +transform.position);
                if (p.transform.position==transform.position)
                {
                    p.GetComponent<MeshRenderer>().enabled = false;

                    //p.SetActive(true);
                }     
            }
        }

        if(distancia<=2.4f)
        {
            ObstacleList = GameObject.FindGameObjectsWithTag("Empty");
            //print(ObstacleList.Length);
            foreach (GameObject p in ObstacleList)
            {
                float distancep = Vector3.Distance(p.transform.position, transform.position);
                //print( "p "+ p.transform.position + "yo" +transform.position);
                if (p.transform.position==transform.position)
                {
                    p.GetComponent<MeshRenderer>().enabled = true;
                    print("toy vacio");
                }
            }
        }

        if(distancia<=2.4f)
        {
            ObstacleList = GameObject.FindGameObjectsWithTag("Trophy");
            //print(ObstacleList.Length);
            foreach (GameObject p in ObstacleList)
            {
                float distancep = Vector3.Distance(p.transform.position, transform.position);
                //print( "p "+ p.transform.position + "yo" +transform.position);
                if (p.transform.position==transform.position)
                {
                    p.GetComponent<MeshRenderer>().enabled = true;
                    print("Buena Cruz Azul");
                }
            }
        }
        else 
        {
            player.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            ObstacleList = GameObject.FindGameObjectsWithTag("Trophy");
            //print(ObstacleList.Length);
            foreach (GameObject p in ObstacleList)
            {
                float distancep = Vector3.Distance(p.transform.position, transform.position);
                //print( "p "+ p.transform.position + "yo" +transform.position);
                if (p.transform.position==transform.position)
                {
                    p.GetComponent<MeshRenderer>().enabled = false;

                    //p.SetActive(true);
                }     
            }
        }
    }  

    
} 