using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveTree : MonoBehaviour
{
    public Terrain terrain;
    public float waterLevel = 20.0f;
    public void RemoveTreeUnderWater()
    {
        TerrainData terrainData = terrain.terrainData;
        TreeInstance[] treeInstances = terrainData.treeInstances;   
        List<TreeInstance> updateTreeInstance = new List<TreeInstance>();

        foreach (TreeInstance treeInstance in treeInstances)
        {
            Vector3 treePosition = Vector3.Scale(treeInstance.position,terrainData.size)+ terrain.transform.position;
            if(treePosition.y >= waterLevel)
            {
                updateTreeInstance.Add(treeInstance);
            }
        }
        terrainData.treeInstances = updateTreeInstance.ToArray();
    }
}
