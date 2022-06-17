using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roketmotion : MonoBehaviour
{
    // Start is called before the first frame update
    float xpozisyon;
    Transform sað, sol;
    void Start()
    {
        InvokeRepeating("süre", 1f, 0.5f);
    }

    // Update is called once per frame
    void süre()
    {
        //yercekimi.AddForce(Vector3.right * 2f);
        float Rand = Random.Range(-20f, 25f);
        transform.position = new Vector3(Rand, transform.position.y, transform.position.z);
        //yercekimi.AddForce(Vector3.left * 2f);
    }
}
