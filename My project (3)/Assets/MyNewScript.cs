using UnityEngine;

public class MyNewScript : MonoBehaviour
{
    public string playerName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("æ»≥Á«œººø‰?" + playerName);
        Debug.LogWarning("æ»≥Á«œººø‰?");
        Debug.LogError("æ»≥Á«œººø‰?");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
