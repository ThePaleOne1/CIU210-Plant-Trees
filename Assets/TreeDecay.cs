using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeDecay : MonoBehaviour
{
    public GameObject tree;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyTree", Random.Range(3f, 60f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DestroyTree()
    {
        Destroy(tree);
    }
}
