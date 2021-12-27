using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] CharacterController playerController;
    [SerializeField] float movementSpeed = 5f;
    [SerializeField] float slideSpeed = 3f;
    [SerializeField] float dodgeSpeed = 3f;
    [SerializeField] float dodgeHeight = 3f;

    [SerializeField] Vector2 _horizontalInput;

    [SerializeField] float gravity = -30f;
    [SerializeField] float jumpHeight = 3.5f;
    [SerializeField] bool jump;
    [SerializeField] bool slide;
    [SerializeField] bool dodge;
    [SerializeField] float jumpCoolTime;
    [SerializeField] float jumpStartTime;
    [SerializeField] float slideCoolTime;
    [SerializeField] float slideStartTime;
    [SerializeField] float dodgeCoolTime;
    [SerializeField] float dodgeStartTime;


    Vector3 _verticalVelocity = Vector3.zero;
    Vector3 _horizontalVelocity = Vector3.zero;

    // Initializes player character controller.
    private void Awake()
    {
        playerController = GetComponent<CharacterController>();
    }

    // Update Fuction calls all the movement funtions and apply it to motion V3 and move the character controller.
    private void Update()
    {
        MovePlayer();
        ApplyGravity();
        HandleJumpInput();
        HandleSlideInput();
        HandleDodgeInput();
        Vector3 motion = _horizontalVelocity + _verticalVelocity;
        playerController.Move(motion * Time.deltaTime);
    }


    // Jump Event Handler Function.
    public void OnJumpPressed()
    {
        jump = true;
        jumpStartTime = Time.time;
    }

    public void OnJumpExit()
    {
        jump = false;
    }

    void HandleJumpInput()
    {
        if (jump)
        {
            float totalJumpTime = Time.time - jumpStartTime;
            if (totalJumpTime > jumpCoolTime)
            {
                jump = false;
            }
        }
    }

    // Slide Event Handler Function.
    public void OnSlide()
    {
        slide = true;
        slideStartTime = Time.time;
        playerController.height = 0.1f;
    }

    public void OnSlideExit()
    {
        slide = false;
        playerController.height = 1.8f;
    }

    void HandleSlideInput()
    {
        if (slide)
        {
            float totalSlideTime = Time.time - slideStartTime;
            if (totalSlideTime > slideCoolTime)
            {
                OnSlideExit();
            }
        }
    }

    // Dodge Event Handler Function.
    public void OnDodge()
    {
        dodge = true;
        dodgeStartTime = Time.time;
    }

    public void OnDodgeExit()
    {
        dodge = false;
    }

    void HandleDodgeInput()
    {
        if (dodge)
        {
            float totalDodgeTime = Time.time - dodgeStartTime;
            if (totalDodgeTime > slideCoolTime)
            {
                OnDodgeExit();
            }
        }
    }

    // Gravity on Player and also calls Jump function
    void ApplyGravity()
    {
        _verticalVelocity.y += gravity * Time.deltaTime;
        PlayerJump();
    }

    // Player Jump Movement
    void PlayerJump()
    {
        if(playerController.isGrounded && jump)
        {
            _verticalVelocity.y = Mathf.Sqrt(-2 * jumpHeight * gravity);
        }
    }

    // Player Horizontal Movement
    public void MovePlayer()
    {
        _horizontalVelocity = (transform.right * _horizontalInput.x + transform.forward * _horizontalInput.y) * movementSpeed;
        
        // Slide movement
        if(slide && _horizontalVelocity != Vector3.zero)
        {
            _horizontalVelocity *= slideSpeed;
        }
        else if(slide && _horizontalVelocity == Vector3.zero)
        {
            _horizontalVelocity = (transform.forward * movementSpeed * slideSpeed);
        }

        // Dodge movement
        if (dodge && _horizontalVelocity != Vector3.zero)
        {
            _horizontalVelocity *= dodgeSpeed;
            _verticalVelocity.y = Mathf.Sqrt(-2 * dodgeHeight * gravity);
        }
    }
    
    // Input Handler for horizontal Movement.
    public void ReceiveInput(Vector2 horizontalInput)
    {
        _horizontalInput = horizontalInput;
    }
}
