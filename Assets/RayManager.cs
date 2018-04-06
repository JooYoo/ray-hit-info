using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RayManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        RaycastHit hitInfo;
        // create a Ray ba
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //todo: create a blue line to show ScreenPointToRay based on mouse position
        Debug.DrawRay(ray.origin, ray.direction, Color.blue);

        // click mouse return hit object info
        if (Input.GetMouseButtonDown(0))
        {
           
            // draw a red line based on mouse position, simulate the Ray
            Debug.DrawRay(ray.origin, ray.direction, Color.red);
            // get the hitInfo of the Ray
            if (Physics.Raycast(ray,out hitInfo))
            {
                if (hitInfo.collider.gameObject.name == "ImCube")
                {
                    Debug.Log("hit cube");
                }

                if (hitInfo.collider.gameObject.name == "ImSphere")
                {
                    Debug.Log("hit Sphere");
                }
            }
        }
    }
}
