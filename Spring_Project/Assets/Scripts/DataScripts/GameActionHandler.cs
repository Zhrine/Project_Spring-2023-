using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameAction gameActionObj;
    public UnityEvent onRaise;

    void Start()
    {
        gameActionObj.raise += Raise;
    }
	
    private void Raise()
    {
        onRaise?.Invoke();	
    }

}