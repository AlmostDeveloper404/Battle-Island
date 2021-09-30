using UnityEngine;

public class IconsDisplayer : MonoBehaviour
{
    public GameObject[] icons;

    private void Awake()
    {
        icons = new GameObject[transform.childCount];
        for (int i = 0; i < icons.Length; i++)
        {
            icons[i] = transform.GetChild(i).gameObject;
        }
    }

    public void UpdateIcon(int remainingEnemies)
    {
        Debug.Log("Yep");
        for (int i = 0; i < icons.Length; i++)
        {
            icons[i].SetActive(i<remainingEnemies);
        }
    }
}
