using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    // Variables
    [SerializeField] private float jumpStrength = 5f;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ForceMode2d.Impulse applies an instant force.
            rb.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
        }
    }
}
