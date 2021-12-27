using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] float sensetivityX,sensetivityY;
    [SerializeField] float bulletTimeSensetivityX, bulletTimesensetivityY;
    [SerializeField] Transform player, lookRoot;
    [SerializeField] float XClamp;
    float xRotation = 0f;

    public bool isInBulletTime;
    
    float mouseX,mouseY;

    // Lock the cursor at the start of the game.
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        if(Cursor.lockState == CursorLockMode.Locked)
        {
            LookAround();
        }
    }

    // Look Around Mechanics.
    void LookAround()
    {
        // Rotate Player transform in Y-Axis with MouseX input.
        player.Rotate(Vector2.up * mouseX * Time.deltaTime);

        // Camera Rotation Value around X-Axis with MouseY input.
        xRotation -= mouseY;
        Vector3 targetRotation = lookRoot.rotation.eulerAngles;
        targetRotation.x = Mathf.Clamp(xRotation, -XClamp, XClamp);
        lookRoot.rotation = Quaternion.Euler(targetRotation);
    }

    // Locking and Unlocking the Cursor.
    public void ToogleCursor()
    {
        Cursor.lockState = (Cursor.lockState == CursorLockMode.Locked) ? CursorLockMode.None : CursorLockMode.Locked;
        Cursor.visible = Cursor.lockState != CursorLockMode.Locked;
    }

    // Receive Input of Mouse.
    public void ReceiveInput(Vector2 mouseInput)
    {
        mouseX = mouseInput.x * (isInBulletTime ? bulletTimeSensetivityX : sensetivityX);
        mouseY = mouseInput.y * (isInBulletTime ? bulletTimesensetivityY : sensetivityY);
    }
}
