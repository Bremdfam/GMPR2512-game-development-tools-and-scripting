using UnityEngine;

public class Teleporter : MonoBehaviour
{
    // Variables
    [SerializeField] private Transform _destination;
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if this is our player
        if (other.GetComponent<Rigidbody2D>() != null)
        {
            Debug.Log("EH, I'M TRIGGERING ERE");
            other.transform.position = _destination.position;

            // Kill the momentum when entering the teleporter
            // other.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
        }
    }
}
