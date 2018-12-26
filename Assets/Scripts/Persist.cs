using UnityEngine;
using UnityEngine.SceneManagement;

public class Persist : MonoBehaviour
{

    static bool created;

    void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(gameObject);
            created = true;
        }
    }
}
