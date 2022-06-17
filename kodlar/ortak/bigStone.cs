using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigStone : MonoBehaviour
{
    public Transform tas1;
    float tas1x;
    float mesafe1;
    // public GameObject tass1;

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
        mesafe1 = transform.position.z - tas1.position.z;
        tas1x = Random.Range(-5.45f, 5.45f);

        if (0 < mesafe1 && mesafe1 < 5)
        {
            tas1.transform.position = new Vector3(tas1x, tas1.transform.position.y, transform.position.z + 80f);
        }
    }
}
