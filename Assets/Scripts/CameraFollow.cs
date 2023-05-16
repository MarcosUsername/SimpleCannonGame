using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour 
{

    public Transform tTarget;
    public Vector3 vcOffset;
    [Range(1, 10)]
    public float fSmoothFactor;
    public Vector3 vcMinValues;
    public Vector3 vcMaxValues;

    void Start()
    {




    }

    void FixedUpdate()
    {

        Follow();


    }

    void Update()
    {



    }

    void Follow()
    {

        transform.position = tTarget.position + vcOffset;

        Vector3 vcBoundPosition = new Vector3(
            Mathf.Clamp(tTarget.position.x, vcMinValues.x, vcMaxValues.x),
            Mathf.Clamp(tTarget.position.y, vcMinValues.y, vcMaxValues.y),
            Mathf.Clamp(tTarget.position.z, vcMinValues.z, vcMaxValues.z));

        Vector3 vcSmoothPosition = Vector3.Lerp(transform.position, vcBoundPosition, fSmoothFactor * Time.fixedDeltaTime);
        transform.position = vcSmoothPosition;

    }

}
