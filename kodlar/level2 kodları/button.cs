using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    int puan = 0;
    int i = 1;
    public void sahnegecis()
    {
        puan = PlayerPrefs.GetInt("puan");
        SceneManager.LoadScene(4);
        PlayerPrefs.SetInt("i", i);
    }
}
