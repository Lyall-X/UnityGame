using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    void Awake()
    {
        OnAwake();
    }

    void Start()
    {
        OnStart();
    }
    //用于物理计算
    void FixedUpdate()
    {
        OnFixedUpdate();
    }
    void Update()
    {
        OnUpdate();
    }
    //在调用所有 Update 函数后调用
    void LateUpdate() 
    {
        OnLateUpdate();    
    }

     void OnDestroy() 
    {
        OnDestoryMe();     
    }

    protected virtual void OnAwake() {}
    protected virtual void OnStart() {}
    protected virtual void OnFixedUpdate() {}
    protected virtual void OnUpdate() {}
    protected virtual void OnLateUpdate() {}
    protected virtual void OnDestoryMe() {}

}