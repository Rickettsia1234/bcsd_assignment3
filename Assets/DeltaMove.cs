using UnityEngine;

public class DeltaMove : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);

    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical"),
            0);
        transform.Translate(vec * Time.deltaTime);

        transform.position = Vector3.MoveTowards(transform.position, target, 1f * Time.deltaTime);
        transform.position = Vector3.Lerp(transform.position, target, 1f * Time.deltaTime);
        transform.position = Vector3.Slerp(transform.position, target, 1f * Time.deltaTime);
    }
}