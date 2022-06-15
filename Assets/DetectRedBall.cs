using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectRedBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.name == "RedButton")
            {
                Debug.Log("Clicked Red Button");
            }
        }
    }
}
