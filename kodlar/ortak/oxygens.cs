using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oxygens : MonoBehaviour
{
    public Transform oksijen1;
    public Transform oksijen2;
    public Transform oksijen3;
    float oksijenx;
    float mesafe1, mesafe2, mesafe3;
    public GameObject ok1, ok2, ok3;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mesafe1 = transform.position.z - oksijen1.position.z;
        mesafe2 = transform.position.z - oksijen2.position.z;
        mesafe3 = transform.position.z - oksijen3.position.z;
        oksijenx = Random.Range(-5.45f, 5.45f);

        if (1 < mesafe1 && mesafe1 < 5)
        {
            oksijen1.transform.position = new Vector3(oksijenx, oksijen1.transform.position.y, transform.position.z + 50f);
            ok1.SetActive(true);

        }

        if (1 < mesafe2 && mesafe2 < 5)
        {
            oksijen2.transform.position = new Vector3(oksijenx, oksijen2.transform.position.y, transform.position.z + 80f);
            ok2.SetActive(true);
        }


        if (1 < mesafe3 && mesafe3 < 5)
        {
            oksijen3.transform.position = new Vector3(oksijenx, oksijen2.transform.position.y, transform.position.z + 100f);
            ok3.SetActive(true);
        }
    }
}
