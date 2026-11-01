using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("초기화: Awake");
    }

    void OnEnable()
    {
        Debug.Log("활성화: OnEnable");
    }

    void Start()
    {
        Debug.Log("초기화: Start");
    }

    void FixedUpdate()
    {
        Debug.Log("물리 연산: FixedUpdate");
    }

    void Update()
    {
        Debug.Log("로직: Update");
    }

    void LateUpdate()
    {
        Debug.Log("후처리: LateUpdate");
    }

    void OnDisable()
    {
        Debug.Log("비활성화: OnDisable");
    }

    void OnDestroy()
    {
        Debug.Log("해제: OnDestroy");
    }
}
