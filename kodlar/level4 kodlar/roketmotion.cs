using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roketmotion : MonoBehaviour
{
    // Start is called before the first frame update
    float xpozisyon;
    Transform sa�, sol;
    void Start()
    {
        InvokeRepeating("s�re", 1f, 0.5f);
    }

    // Update is called once per frame
    void s�re()
    {
        //yercekimi.AddForce(Vector3.right * 2f);
        float Rand = Random.Range(-20f, 25f);
        transform.position = new Vector3(Rand, transform.position.y, transform.position.z);
        //yercekimi.AddForce(Vector3.left * 2f);
    }
}
