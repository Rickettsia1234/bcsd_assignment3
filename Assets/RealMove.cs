using UnityEngine;

public class RealMove : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);
    Vector3 vel = Vector3.zero;

    void Update()
    {
        MoveMoveTowards();
        MoveSmoothDamp();
        MoveLerp();
        MoveSlerp();
    }

    void MoveMoveTowards()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, 2f);
    }

    void MoveSmoothDamp()
    {
        transform.position = Vector3.SmoothDamp(transform.position, target, ref vel, 0.1f);
    }

    void MoveLerp()
    {
        transform.position = Vector3.Lerp(transform.position, target, 0.05f);
    }

    void MoveSlerp()
    {
        transform.position = Vector3.Slerp(transform.position, target, 0.05f);
    }
}