using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class SkinnedMeshToMesh : MonoBehaviour
{
    public SkinnedMeshRenderer skinnedMeshRenderer;
    public VisualEffect VFXGraph;
    public float refreshRate;
    void Start()
    {
        StartCoroutine(UpdateVFXGraph());
    }

    IEnumerator UpdateVFXGraph()
    {
       Mesh m = new Mesh();
        skinnedMeshRenderer.BakeMesh(m);
        VFXGraph.SetMesh("Mesh", m);

        yield return new WaitForSeconds(refreshRate);
    }
}
