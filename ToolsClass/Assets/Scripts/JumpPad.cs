using UnityEditor.Callbacks;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    // Variables
    [SerializeField] private float _bounce = 15f;
    private SpriteRenderer _renderer;
    private Color _originalColor;

    void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _originalColor = _renderer.color;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check to see of the collision is with the Player
        if(collision.gameObject.CompareTag("Player"))
        {
            // Add a bounce if there's a rigidbody on Player
            Rigidbody2D _rb = collision.gameObject.GetComponent<Rigidbody2D>();
            if(_rb != null)
            {
                _rb.AddForce(Vector2.up * _bounce, ForceMode2D.Impulse);
            }
            // Visual Feedback
            _renderer.color = Color.green;
            Invoke("ResetColor", 0.5f);
        }
    }
    private void ResetColor()
    {
        _renderer.color = _originalColor;
    }
}
