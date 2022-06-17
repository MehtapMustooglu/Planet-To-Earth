using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yoluzama : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "astronauta")
        {
            transform.localScale += new Vector3(0f, 0f, +100f);
        }
    }
}
