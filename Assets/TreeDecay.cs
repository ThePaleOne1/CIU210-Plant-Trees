using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeDecay : MonoBehaviour
{
    public GameObject tree;
    public GameObject stump;

    bool isfalling = false;
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
        if (isfalling)
        {
            tree.transform.RotateAround(Vector3.forward, Vector3.forward, 5);
        }

        if (tree.transform.rotation.eulerAngles.z > 90)
        {
            Invoke("DestroyTree", 0);
            tree.transform.SetPositionAndRotation(transform.position, transform.rotation);
        }
    }

    void TreeFall()
    {
        isfalling = true;
    }

    void DestroyTree()
    {
        tree.SetActive(false);
        stump.SetActive(true);
        isfalling = false;
    }

}
