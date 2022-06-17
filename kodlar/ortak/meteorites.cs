using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorites : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform tas1;
    public Transform tas2;
    public Transform tas3;
    float tas1x;
    float mesafe1, mesafe2, mesafe3;
    public GameObject tass1, tass2, tass3;

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
        mesafe2 = transform.position.z - tas2.position.z;
        mesafe3 = transform.position.z - tas3.position.z;
        tas1x = Random.Range(-5.45f, 5.45f);
        if (0 < mesafe1 && mesafe1 < 5)
        {
            tas1.transform.position = new Vector3(tas1x, tas1.transform.position.y, transform.position.z + 50f);
            tass1.SetActive(true);
        }

        if (0 < mesafe2 && mesafe2 < 5)
        {
            tas2.transform.position = new Vector3(tas1x, tas2.transform.position.y, transform.position.z + 60f);
            tass2.SetActive(true);
        }

        if (0 < mesafe3 && mesafe3 < 5)
        {
            tas3.transform.position = new Vector3(tas1x, tas3.transform.position.y, transform.position.z + 40f);
            tass3.SetActive(true);
        }
    }
}