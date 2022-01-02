using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input : MonoBehaviour
{
    [SerializeField] PlayerMovement playerMovement;
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

        groundMovement.Jump.performed += _ => playerMovement.OnJumpPressed();
        groundMovement.Jump.canceled += _ => playerMovement.OnJumpExit();

        groundMovement.Slide.performed += _ => playerMovement.OnCrouchPressed();
        groundMovement.Slide.canceled += _ => playerMovement.OnCrouchExit();
        
        //groundMovement.Dodge.performed += _ => movement.OnDodge();
        //groundMovement.Dodge.canceled += _ => movement.OnDodgeExit();

        groundMovement.MouseX.performed += ctx => mouseInput.x = ctx.ReadValue<float>();
        groundMovement.MouseY.performed += ctx => mouseInput.y = ctx.ReadValue<float>();

        inGame.CursorControl.performed += _ => playerMovement.ToogleCursor();

        gameplayActions.slowmo.performed += _ => timeControl.StartBulletTime();
        gameplayActions.slowmo.canceled += _ => timeControl.EndBulletTime();

        // ********************Clean This*******************************

        gameplayActions.shoot.performed += _ => weaponController.StartShooting();
        gameplayActions.shoot.canceled += _ => weaponController.StopShooting();
    }

    private void Update()
    {
        // movement.ReceiveInput(horizontalInput);
        playerMovement.ReceiveInput(horizontalInput);
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

