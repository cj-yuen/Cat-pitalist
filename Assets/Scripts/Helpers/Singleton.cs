using UnityEngine;

public class Singleton<T> : MonoBehavior where T : MonoBehavior 
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            return _instance;
        }
    }

    public void Awake()
    {
        _instance = (T)(object) this; 
    }
}
