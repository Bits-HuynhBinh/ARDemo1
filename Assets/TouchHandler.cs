using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHandler : MonoBehaviour
{

    //Change me to change the touch phase used.
    TouchPhase touchPhase = TouchPhase.Ended;
    Vector3 add;

    bool isZooming;

    Vector3 scaleSmall;
    Vector3 scaleLarge;

    public Camera myCamera;

    private void Awake()
    {
        add = new Vector3(2, 0, 0);
        isZooming = false;

        scaleSmall = new Vector3(5, 5, 5);
        scaleLarge = new Vector3(8, 8, 8);
    }

    void Update()
    {
        //We check if we have more than one touch happening.
        //We also check if the first touches phase is Ended (that the finger was lifted)
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == touchPhase)
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit = new RaycastHit();
            Physics.Raycast(ray, out hit);

            if (hit.collider != null)
            {
                //hit.transform.gameObject.GetComponentInChildren<ScriptLights>().blink = true;
                Transform currentTransform = hit.transform;
                //currentTransform.position = currentTransform.position + add;
                //hit.transform.position = currentTransform.position;

                isZooming = !isZooming;

                if(isZooming)
                {
                    currentTransform.localScale = scaleSmall;
                }
                else
                {
                    currentTransform.localScale = scaleLarge;
                }

            }
        }
    }
}
