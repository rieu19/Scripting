using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parede : MonoBehaviour
{

    public float Velocidade;

    // Start is called before the first frame update
    private void Start()
    {
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.forward * Velocidade * Time.deltaTime);


    }
}
