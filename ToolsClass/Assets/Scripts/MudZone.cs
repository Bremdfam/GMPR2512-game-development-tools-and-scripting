using UnityEngine;

public class MudZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Rigidbody2D _rb = other.GetComponent<Rigidbody2D>();
        if (_rb != null)
        {
            _rb.linearDamping = 5f; // increase drag
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Rigidbody2D _rb = other.GetComponent<Rigidbody2D>();
        if (_rb != null)
        {
            _rb.linearDamping = 0f; // set drag to normal
        }
    }
}
