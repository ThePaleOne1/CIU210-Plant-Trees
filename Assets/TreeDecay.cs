using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeDecay : MonoBehaviour
{
    public GameObject tree;
    public GameObject stump;

    public bool isfallen = false;

    public bool isGowing = false;
    // Start is called before the first frame update
    void Start()
    {
        float rand = Random.Range(3f, 60f);
        Invoke("TreeFall", rand);
        print(rand);

        tree.SetActive(true);
        stump.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isfallen && tree.active == true)
        {
            tree.transform.RotateAround(Vector3.forward, Vector3.forward, 5);
        }
        

        if (tree.transform.rotation.eulerAngles.z > 90)
        {
            //isfallen = false;
            Invoke("DestroyTree", 0);
            tree.transform.SetPositionAndRotation(transform.position, transform.rotation);
        }

        if (tree.transform.position.y < 0)
        {
            tree.transform.Translate(Vector3.up);
        }

        if (isGowing)
        {
            Invoke("GrowTree",0);
            isGowing = false;
        }
    }

    void TreeFall()
    {
        isfallen = true;
    }

    void DestroyTree()
    {
        tree.SetActive(false);
        stump.SetActive(true);
        
        
    }

    void GrowTree()
    {
        isfallen = false;
        tree.SetActive(true);
        stump.SetActive(false);
        tree.transform.position = new Vector3(tree.transform.position.x,-10, tree.transform.position.z);
    }

}
