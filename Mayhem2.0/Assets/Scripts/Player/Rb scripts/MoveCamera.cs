using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    public Transform player;
    public Vector3 posOffset;

    void Update()
    {
        transform.position = player.transform.position + posOffset;
    }
}