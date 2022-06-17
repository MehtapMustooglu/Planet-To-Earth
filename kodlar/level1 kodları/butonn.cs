using UnityEngine;
using UnityEngine.SceneManagement;

public class butonn : MonoBehaviour
{
    int puan = 0;
    int i = 0;
    public void sahnegecis()
    {
        SceneManager.LoadScene(2);
        PlayerPrefs.SetInt("puan", puan);
        PlayerPrefs.SetInt("i", i);
    }
}

