using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteInEditMode]
public class CameraFollowCompnent : MonoBehaviour {

    public Texture tex_near;
    public Vector2 v2_center_near;
    public Vector2 v2_size_near;


    public Texture tex_far;
    public Vector2 v2_center_far;
    public Vector2 v2_size_far;

    public GameObject target;

	public Camera camera;
    // Update is called once per frame

    public void Init(GameObject go, Camera l_camera = null ) 
    {
        target = go;

        if (l_camera != null)
        {
            camera = l_camera;
        }

    }
	void Update () {

        if (camera == null || target == null)
        {
            return;
        }

        Vector3 v3_screenPoint = camera.WorldToScreenPoint(target.transform.position);

        camera.transform.position =Vector3.Lerp(camera.transform.position,  target.transform.position + new Vector3(-8.8f, 2.51f, 5.1f),Time.deltaTime);
        camera.transform.eulerAngles = new Vector3(12.4f, 119, 0);




	}


}
