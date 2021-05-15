using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewCameraController : MonoBehaviour
{
    public Camera topView;
    public Camera playerView;
    public KeyCode changeCamera;
    private float lastFrame;
    // Start is called before the first frame update
    void Start()
    {
        lastFrame = Time.frameCount;
        topView.enabled = true;
        playerView.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount - lastFrame > 5)
        {
            lastFrame = Time.frameCount;
            if (Input.GetKeyDown(changeCamera))
            {
                topView.enabled = !topView.enabled;
                playerView.enabled = !playerView.enabled;
            }
        }
    }
}
