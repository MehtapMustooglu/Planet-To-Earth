using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roketçoğaltma : MonoBehaviour
{
    public Transform roketkonum;
    float randomx;
    float mesafe;

    void Start()
    {
        InvokeRepeating("süre", 1f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        distance();
    }

    void distance()
    {
        mesafe = transform.position.z - roketkonum.position.z;
        randomx = Random.Range(-5.45f, 5.45f);
        if (0 < mesafe && mesafe < 5)
        {
            roketkonum.transform.position = new Vector3(randomx, roketkonum.transform.position.y, transform.position.z + 50f);
        }
    }
}
