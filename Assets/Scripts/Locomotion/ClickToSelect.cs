﻿using UnityEngine;

public class ClickToSelect : MonoBehaviour
{

    RaycastHit hitInfo = new RaycastHit();

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray.origin, ray.direction, out hitInfo))
            {
                Debug.Log(hitInfo.transform.gameObject);
            }
        }
    }
}