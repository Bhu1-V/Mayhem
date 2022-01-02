using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControl : MonoBehaviour
{
    [Range(0,100)]
    [SerializeField] float timeSlowPercentage = 50;
    [SerializeField] float originalTimeScale;

    public void StartBulletTime()
    {
        originalTimeScale = Time.timeScale;
        Time.timeScale = 1 - (timeSlowPercentage / 100f);
    }

    public void EndBulletTime()
    {
        Time.timeScale = originalTimeScale;
    }
}
