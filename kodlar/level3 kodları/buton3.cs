using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buton3 : MonoBehaviour
{
    // Start is called before the first frame update
    int puan;
    int i = 2;
    void Start()
    {
        
    }
    public void sahnegecis()
    {
        puan = PlayerPrefs.GetInt("puan");
        SceneManager.LoadScene(6);
        PlayerPrefs.SetInt("i", i);
    }
}
