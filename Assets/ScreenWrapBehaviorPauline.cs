using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrapBehaviorPauline : MonoBehaviour
{
   SpriteRenderer m_renderer;
    Camera cam;
  

    void Start()
    {
        cam = Camera.main;
        m_renderer = GetComponent<SpriteRenderer>();
       
    }

    void Update()
    {
        ScreenWrap();
    }

    private void ScreenWrap()
    {

        var newPosition = transform.position;

        var viewportPosition = cam.WorldToViewportPoint(transform.position);

        if (viewportPosition.x > 1 || viewportPosition.x < 0)
        {
            newPosition.x = -newPosition.x;

          
        }
        if (viewportPosition.y > 1 || viewportPosition.y < 0)
        {
            newPosition.y = -newPosition.y;

           
        }

        transform.position = newPosition;
    }
}
