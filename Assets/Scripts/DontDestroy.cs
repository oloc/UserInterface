using UnityEngine;

public class DontDestroy : MonoBehaviour
{

    private const string MUSIC_TAG = "Music";

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag(MUSIC_TAG);
        if (objs.Length > 1)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
}