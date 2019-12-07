using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastClick : MonoBehaviour
{

    Ray ray;
    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("MouseDown");
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "Tree")
                {
                    print("Found Tree");
                    if (hit.collider.GetComponent<TreeDecay>().isfallen)
                    {
                        print("Is has fallen");
                        hit.collider.GetComponent<TreeDecay>().isGowing = true;
                    }
                }

            }

        }
    }
}
