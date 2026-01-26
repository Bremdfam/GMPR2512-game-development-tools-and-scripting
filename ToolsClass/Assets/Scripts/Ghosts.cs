using UnityEngine;

public class Ghosts : MonoBehaviour
{
    // GOAL: To control our ghost objects, adjust their variables and make them move around.
    // Variables

    // Identify our ghost object
    // Change color
    // Change to static
    void Start()
    {
        Debug.Log("Ghost here: " + gameObject.name);

        GetComponent<SpriteRenderer>().color = Color.cyan;
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;

    }

    // Rotate ghost every frame
    void Update()
    {
        transform.Rotate(0,0,1);
    }
}

