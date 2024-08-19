using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    [SerializeField] //means you can use this in spector, but not in the code 
    private UnityEvent onTrigger;

    [SerializeField]
    private List<string> validTags = new List<string>();

    [SerializeField]
    private float delayInSeconds;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    //private void InvokeMethod(Collider other)
    //{
    //    if (validTags.Contains(other.tag))
    //        onTrigger?.Invoke(); //? only activates if someone is waiting for the event 
    //}

   /* private void DelayedInvoke(string tag)
    {
        if (validTags.Contains(tag))
            onTrigger?.Invoke();
    }
   */

    public void OnTriggerEnter(Collider other)
    {
        StartCoroutine(DelayedInvoke(other.tag));
    }

    private IEnumerator DelayedInvoke(string tag)
    {
        if (validTags.Contains(tag))
        {
            yield return new WaitForSeconds(delayInSeconds);
            onTrigger?.Invoke();
        }
    }

}
