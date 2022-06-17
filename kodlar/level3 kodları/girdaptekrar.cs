using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girdaptekrar : MonoBehaviour
{

    float mesafe;
    public Transform gr;
    float grx;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        distance();
    }

    void distance()
    {
        mesafe = transform.position.z - gr.position.z;
        grx = Random.Range(-5.45f, 5.45f);
        if (mesafe > 10)
        {
            gr.transform.position = new Vector3(grx, gr.transform.position.y, transform.position.z + 50f);
        }
    }
}
