using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RandomPosition : MonoBehaviour
{
    public int numberToSpawn;
    public List<GameObject> spawnPool;
    public GameObject quad;
    public Material[] texturas;
    public Material[] texturas2;

    void Start()
    {
        spawnObjects();
        var shuffled = texturas.OrderBy(x => System.Guid.NewGuid()).ToList();
        for (int i = 0; i < 5; i++)
        {
            print(shuffled[i]);
            texturas2[i] = shuffled[i];
        }

    }

    public void spawnObjects()
    {
        destroyObjects();
        int randomItem = 0;
        GameObject toSpawn;
        MeshCollider c = quad.GetComponent<MeshCollider>();

        float screenX, screenY, screenZ;
        Vector3 pos;

        for (int i = 0; i < numberToSpawn; i++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
            screenZ = Random.Range(c.bounds.min.z, c.bounds.max.z);
            pos = new Vector3(screenX, screenY, screenZ);

            GameObject planeta= Instantiate(toSpawn, pos, toSpawn.transform.rotation);
            planeta.GetComponent<Renderer>().material = texturas2[i];
            planeta.GetComponent<EspacioVectorial>().enabled = true;
        }
    }
    private void destroyObjects()
    {
        foreach (GameObject o in GameObject.FindGameObjectsWithTag("Spawnable"))
        {
            Destroy(o);
        }
    }

}
