using UnityEngine;
using UnityEngine.SceneManagement;

public class buton4 : MonoBehaviour
{
    int puan;
    int i = 3;
    public void sahnegecis()
    {
        puan = PlayerPrefs.GetInt("puan");
        SceneManager.LoadScene(8);
        PlayerPrefs.SetInt("i", i);
    }
}

