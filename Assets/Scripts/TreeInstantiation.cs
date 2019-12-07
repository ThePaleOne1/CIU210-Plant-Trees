using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeInstantiation : MonoBehaviour
{
    public GameObject theTree;
    public Terrain theTerrain;

    // Use this for initialization
    void Start()
    {
        TerrainData theTerrainData;
        theTerrainData = theTerrain.terrainData;

       

        // Grab the island's terrain data
        
        // For every tree on the island
        foreach (TreeInstance tree in theTerrainData.treeInstances)
        {
            // Find its local position scaled by the terrain size (to find the real world position)
            Vector3 worldTreePos = Vector3.Scale(tree.position, theTerrainData.size) + Terrain.activeTerrain.transform.position;
            Instantiate(theTree, worldTreePos, Quaternion.identity); // Create a prefab tree on its pos
        }
        // Then delete all trees on the island
        List<TreeInstance> newTrees = new List<TreeInstance>(0);
        theTerrainData.treeInstances = newTrees.ToArray();
    }
}
