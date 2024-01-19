using UnityEngine;
using UnityEngine.EventSystems;

public class RightBtn : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool ispressed = false;
    public GameObject Player;
    public float Force;

    void FixedUpdate()
    {
        if (ispressed)
        {
            Player.transform.Translate(Force * Time.deltaTime, 0, 0);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }

}

