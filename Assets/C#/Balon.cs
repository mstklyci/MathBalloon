using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balon : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, float.MaxValue))
            {
                if (hit.rigidbody)
                {
                    Destroy(hit.rigidbody.gameObject);
                }
            }
        }     
    }
}