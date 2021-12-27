using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControl : MonoBehaviour
{
    [Range(0,100)]
    [SerializeField] float timeSlowPercentage = 50;
    [SerializeField] float originalTimeScale;
    public MouseLook mouseLook;

    public void StartBulletTime()
    {
        originalTimeScale = Time.timeScale;
        Time.timeScale = 1 - (timeSlowPercentage / 100f);
        mouseLook.isInBulletTime = true;
    }

    public void EndBulletTime()
    {
        mouseLook.isInBulletTime = false;
        Time.timeScale = originalTimeScale;
    }
}
