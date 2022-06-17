using UnityEngine;
using UnityEngine.SceneManagement;

public class buton5 : MonoBehaviour
{
    int puan;
    int i = 4;
    public void sahnegecis()
    {
        puan = PlayerPrefs.GetInt("puan");
        SceneManager.LoadScene(10);
        PlayerPrefs.SetInt("i", i);
    }
}
