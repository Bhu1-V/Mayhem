using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input : MonoBehaviour
{
    [SerializeField] Movement movement;
    [SerializeField] MouseLook mouseLook;
    [SerializeField] TimeControl timeControl;
    [SerializeField] WeaponController weaponController;

    public PlayerInputAction controls;
    public PlayerInputAction.GroundMovementActions groundMovement;
    public PlayerInputAction.InGameActions inGame;
    public PlayerInputAction.GameplayControlsActions gameplayActions;

    Vector2 horizontalInput;
    Vector2 mouseInput;
    bool jump;

    private void Awake()
    {
        controls = new PlayerInputAction();
        groundMovement = controls.GroundMovement;
        inGame = controls.InGame;
        gameplayActions = controls.gameplayControls;

        groundMovement.Move.performed += ctx => horizontalInput = ctx.ReadValue<Vector2>();

        groundMovement.Jump.performed += _ => movement.OnJumpPressed();
        groundMovement.Jump.canceled += _ => movement.OnJumpExit();

        groundMovement.Slide.performed += _ => movement.OnSlide();
        groundMovement.Slide.canceled += _ => movement.OnSlideExit();
        
        groundMovement.Dodge.performed += _ => movement.OnDodge();
        groundMovement.Dodge.canceled += _ => movement.OnDodgeExit();

        groundMovement.MouseX.performed += ctx => mouseInput.x = ctx.ReadValue<float>();
        groundMovement.MouseY.performed += ctx => mouseInput.y = ctx.ReadValue<float>();

        inGame.CursorControl.performed += _ => mouseLook.ToogleCursor();

        gameplayActions.slowmo.performed += _ => timeControl.StartBulletTime();
        gameplayActions.slowmo.canceled += _ => timeControl.EndBulletTime();

        // ********************Clean This*******************************

        gameplayActions.shoot.performed += _ => weaponController.StartShooting();
        gameplayActions.shoot.canceled += _ => weaponController.StopShooting();
    }

    private void Update()
    {
        movement.ReceiveInput(horizontalInput);
        mouseLook.ReceiveInput(mouseInput);
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}

