using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class level1finish : MonoBehaviour
{
    // Start is called before the first frame update
    public int puan;
    public Text puandeger;
    public Text puan_yazi;

    int i;

    void Start()
    {
        puan = gameObject.GetComponent<Run>().puan;
    }
    void Update()
    {
        Score();
        puandeger.text = puan + "";
    }

    void Score()
    {
         puan = PlayerPrefs.GetInt("puan");
        i = PlayerPrefs.GetInt("i");

         if (puan >= 100 && i==0)
         {
             Stop();
             Invoke("SceneLoadLevel2", 2);
             PlayerPrefs.SetInt("puan", puan);
         } 

        if (puan >= 200 && i ==1)
        {
            Stop();
            Invoke("SceneLoadLevel3", 2);
        }

        if(puan >= 300 && i==2)
        {
            Stop();
            Invoke("SceneLoadLevel4", 2);
        }

        if(puan >= 400 && i==3)
        {
            Stop();
            Invoke("SceneLoadLevel5", 2);
        }

        if(puan >= 500 && i==4)
        {
            Stop();
            Invoke("SceneLoadWin", 2);
        }

        else
        {

        }
    }
    void Stop()
    {
        transform.Translate(new Vector3(0, 0, 0));
        puandeger.color = Color.yellow;
        puan_yazi.color = Color.yellow;
    }
    void SceneLoadLevel2()
    {
        SceneManager.LoadScene(3);
    }

    void SceneLoadLevel3()
    {
        SceneManager.LoadScene(5);
    }

    void SceneLoadLevel4()
    {
        SceneManager.LoadScene(7);
    }

    void SceneLoadLevel5()
    {
        SceneManager.LoadScene(9);
    }

    void SceneLoadWin()
    {
        SceneManager.LoadScene(11);
    }
}
