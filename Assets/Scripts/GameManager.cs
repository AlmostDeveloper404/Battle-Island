using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (instance!=null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }

    public GameObject FinalPanal;
    public void Win()
    {
        PlayerPrefs.SetInt("Health",PlayerHealth._health);
        FinalPanal.SetActive(true);
    }

    [ContextMenu("LoadNextLevel")]
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void Lose()
    {
        FinalPanal.SetActive(true);
        //SceneManager.LoadScene(0);
    }

    
}
