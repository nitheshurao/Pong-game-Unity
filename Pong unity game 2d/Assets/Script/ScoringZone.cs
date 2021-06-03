using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class ScoringZone : MonoBehaviour
{

    public EventTrigger.TriggerEvent scoreTrigger;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Ball ball = other.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            //BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke(new BaseEventData(EventSystem.current));
        }
    }

}
