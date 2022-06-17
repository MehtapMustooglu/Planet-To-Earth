using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Run : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody yercekimi;
    Vector3 konum = new Vector3(0, 0, 10);
    float xpozisyon;

    public AudioSource o2ses;
    public Transform o2ef;
    public AudioSource patlamases;
    public Transform goktasef;
    public Transform buyukgoktasef;
    public Transform roketatesef;

    public int puan;
    public AudioSource girdapses;

    void Start()
    {
        puan = PlayerPrefs.GetInt("puan");
        Debug.Log("yavv");
        yercekimi = GetComponent<Rigidbody>();
        o2ef.GetComponent<ParticleSystem>().Stop();
        patlamases.Stop();
        o2ses.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        motionFuncktion();
        PointSet();
    }

    private void motionFuncktion()
    {
        transform.Translate(konum * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(0.5f * Time.deltaTime * 50, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + new Vector3(-0.5f * Time.deltaTime * 50, 0, 0);
        }

        xpozisyon = Mathf.Clamp(transform.position.x, -5.80f, 6.70f);
        transform.position = new Vector3(xpozisyon, transform.position.y, transform.position.z);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "BUSEbeyaz")
        {
            other.gameObject.SetActive(false);
            oxygenwin();
        }

        if (other.gameObject.tag == "göktaþý")
        {
            other.gameObject.SetActive(false);
            MeteorCollision();
        }

        if (other.gameObject.name == "buyuktas")
        {
            other.gameObject.SetActive(false);
            bigStone();
        }

        if (other.gameObject.name == "roket")
        {
            other.gameObject.SetActive(false);
            rocketStrike();
        }

        if(other.gameObject.name == "AlienPlanet")
        {
            yercekimi.useGravity = true;
            konum = new Vector3(0, 0, 0);
            girdapses.Play();
            Invoke("geç", 2);
        }
    }


    /* void OnCollisionEnter(Collision girdap)
    {
        if (girdap.gameObject.name == "AlienPlanet")
        {
            // yercekimi = GetComponent<Rigidbody>();
            yercekimi.useGravity = true;
            konum = new Vector3(0, 0, 0);
            //test=StartCoroutine(bekle());
            girdapses.Play();
            Invoke("geç", 2);
        }
    } */
    void geç()
    {
        SceneManager.LoadScene(12);
    }

    private void oxygenwin()
    {
        puan = puan + 10;
        o2ef.transform.position = transform.position;
        o2ef.GetComponent<ParticleSystem>().Play();
        o2ses.Play();
    }

    private void MeteorCollision()
    {
        puan = puan - 5;
        goktasef.transform.position = transform.position;
        goktasef.GetComponent<ParticleSystem>().Play();
        patlamases.Play();
    }

    private void bigStone()
    {
        puan = puan - 10;
        buyukgoktasef.transform.position = transform.position;
        buyukgoktasef.GetComponent<ParticleSystem>().Play();
        patlamases.Play();
    }

    private void rocketStrike()
    {
        roketatesef.transform.position = transform.position;
        roketatesef.GetComponent<ParticleSystem>().Play();
    }

    void PointSet()
    {
        Debug.Log(puan);
        PlayerPrefs.SetInt("puan", puan);
    }

}
