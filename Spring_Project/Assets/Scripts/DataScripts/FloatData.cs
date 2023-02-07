using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class FloatData :ScriptableObject
{

    public float value;
    public UnityEvent onUpdate, onMinEvent, onMaxEvent;
    //public so it can be used in unity events
    public void UpdateValue (float num)
    {
        value += num;
        onUpdate.Invoke();
    }
    
    public void CheckMin (float num)
    {
        if (value <=num)
        {
            value = num;
            onMinEvent.Invoke();
        }
    }
    //you can havetwo arguments normall, but unity events needs them to be seperate
    public void CheckMax (float num)
    {
        if (value >=num)
        {
            value = num;
            onMaxEvent.Invoke();
        }
    }
	
	
}
