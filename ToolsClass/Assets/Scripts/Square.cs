using UnityEngine;
using UnityEngine.InputSystem;

public class Square : MonoBehaviour
{
    private PlayerInputActions _playerInput;
    private Vector2 _moveInput;
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private float _jumpStrength = 5f;
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
        _playerInput.Player.Jump.performed += ctx => Jump();
    }

    private void Update()
    {
        // Read jump input
        

    }

    void FixedUpdate()
    {
        // Read move input
        _moveInput = _playerInput.Player.ActionToMove.ReadValue<Vector2>();

        // Apply Velocity
        // _rb.linearVelocity = _moveInput * _moveSpeed;
        _rb.linearVelocity = new Vector2(_moveInput.x * _moveSpeed, _rb.linearVelocity.y);
        

        // Apply movement
        transform.Translate(_moveInput * _moveSpeed * Time.deltaTime);
    }

    private void Jump()
    {
        _rb.AddForce(Vector2.up * _jumpStrength, ForceMode2D.Impulse);
        Debug.Log("Jumping");
    }
}
