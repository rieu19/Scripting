using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float SpawnerTempo = 5f;
    
    public List<GameObject> Paredes = new List<GameObject>();



    // Start is called before the first frame update
    void Start()
    {
        
    }


    float TempoCont;
    // Update is called once per frame
    void Update()
    {
        TempoCont += Time.deltaTime;

        if(TempoCont >= SpawnerTempo)
        {
            Instantiate(Paredes[Random.Range(0, Paredes.Count)], transform.position, transform.rotation);


            TempoCont = 0f;
        }


    }
}
