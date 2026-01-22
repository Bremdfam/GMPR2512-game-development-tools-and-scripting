using UnityEngine;
using UnityEngine.InputSystem;

public class Square : MonoBehaviour
{
    private PlayerInputActions _playerInput;
    private Vector2 _moveInput;
    [SerializeField] private float _moveSpeed = 5f;
    private Rigidbody2D _rb; // Reference to RigidBody component

    private void Awake()
    {
        _playerInput = new PlayerInputActions();
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Debugging");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Read move input
        _moveInput = _playerInput.Player.ActionToMove.ReadValue<Vector2>();

        // Apply Velocity
        _rb.linearVelocity = _moveInput * _moveSpeed;

        // Apply movement
        transform.Translate(_moveInput * _moveSpeed * Time.deltaTime);
    }
}
