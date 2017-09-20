using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeRenderTex : MonoBehaviour {
    public Camera targetCam;
    public Material targetMat;
    int screenRes;

    void Start()
    {
        updateTex();
    }

    private void Update()
    {
        if(screenRes != Screen.width + Screen.height)
        {
            updateTex();
        }
        screenRes = Screen.width + Screen.height;
    }

    private void updateTex()
    {
        targetCam.targetTexture.Release();
        targetCam.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        targetMat.mainTexture = targetCam.targetTexture;
    }
}
