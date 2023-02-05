using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoRoutineBehavior : MonoBehaviour
{
    public UnityEvent startEvent, repeatUntilFalseEvent;

    public bool canRun;
    public float seconds = 3.0f;
    private WaitForSeconds _wfsObj;
    private WaitForFixedUpdate _wffuObj;

    public void Start()
    {
        startEvent.Invoke();
        _wfsObj = new WaitForSeconds(seconds);
        _wffuObj = new WaitForFixedUpdate();
    }
    
    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }

    private IEnumerator RepeatUntilFalse()
    {
        while (canRun)
        {
            yield return _wfsObj;    
            repeatUntilFalseEvent.Invoke();
        }
    }
}