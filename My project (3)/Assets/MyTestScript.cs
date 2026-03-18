using UnityEngine;

public class MyTestScript : MonoBehaviour
{

    public string playerName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("æ»≥Á«œººø‰?  " + playerName);
        Debug.LogError("æ»≥Á«œººø‰ 222");
        Debug.LogWarning("æ»≥Á«œººø‰ 333");

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("12345");
    }
}
