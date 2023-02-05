using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]	

public class ImageBehavior : MonoBehaviour
{
    public UnityEvent startEvent;
    private Image imageObj;
	
    void start()
    {
        imageObj = GetComponent<Image>();
        startEvent.Invoke();
    }

    public void UpdateImage(float data)
    {// obj not working rn for some reason
        
        //imageObj.fillAmount = Obj.value;
    }
	
}