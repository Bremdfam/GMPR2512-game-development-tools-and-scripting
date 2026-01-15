using UnityEngine;

public class Square : MonoBehaviour
{
    // Variables

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Debugging");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((float)0.01,0,0);
        
    }
}
