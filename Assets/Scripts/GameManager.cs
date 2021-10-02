using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int CurrentScene;

    UIManager uIManager;

    public GameObject StartPanal;
    public Text LevelText;

    private void Awake()
    {
        if (instance!=null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }

    private void Start()
    {
        StartPanal.SetActive(true);
        LevelText.text = "Level " + CurrentScene ;
        uIManager = UIManager.instance;
        uIManager.UpdateLevel(CurrentScene);
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
        Debug.Log("Yep");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void Lose()
    {
        FinalPanal.SetActive(true);
        //SceneManager.LoadScene(0);
    }

    
}
