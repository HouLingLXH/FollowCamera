using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CameraFollowCompnent))]
public class CameraFollowEditor : Editor {

    static Texture s_tex_near;
    static Texture s_tex_far;


    private Vector2 v2_conversionCenter_near;
    private Vector2 v2_conversionCenter_far;
    private Vector2 v2_conversionSize_near;
    private Vector2 v2_conversionSize_far;

    private CameraFollowCompnent compnent;

    void OnSceneGUI()
    {
        compnent = target as CameraFollowCompnent;
        GetData();
        DrawUI();
    }

    //获取数据
    private void GetData()
    {
        s_tex_near = compnent.tex_near;
        s_tex_far = compnent.tex_far;

        v2_conversionSize_near = compnent.v2_size_near;
        v2_conversionSize_far = compnent.v2_size_far;

        ConversionCenter();
    }

    //换算中心
    private void ConversionCenter()
    {
        v2_conversionCenter_near = compnent.v2_center_near;
        v2_conversionCenter_near = new Vector2(v2_conversionCenter_near.x + Screen.width * 0.5f, v2_conversionCenter_near.y  + Screen.height * 0.5f);

        v2_conversionCenter_far = compnent.v2_center_far;
        v2_conversionCenter_far = new Vector2(v2_conversionCenter_far.x + Screen.width * 0.5f, v2_conversionCenter_far.y + Screen.height * 0.5f);

    }


    //绘制UI
    private void DrawUI()
    {
        Handles.BeginGUI();
        GUI.DrawTexture(new Rect(v2_conversionCenter_far.x - v2_conversionSize_far.x, v2_conversionCenter_far.y - v2_conversionSize_far.y, v2_conversionSize_far.x * 2, v2_conversionSize_far.y *2), s_tex_far,ScaleMode.StretchToFill);
        GUI.DrawTexture(new Rect(v2_conversionCenter_near.x - v2_conversionSize_near.x, v2_conversionCenter_near.y - v2_conversionSize_near.y, v2_conversionSize_near.x * 2, v2_conversionSize_near.y * 2), s_tex_near,ScaleMode.StretchToFill);

        Handles.EndGUI();
    }
}
