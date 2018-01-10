using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Meta;
using UnityEngine.UI;

public class WebcamTest : MonoBehaviour {
    public WebCamTexture webcamTexture;
    public RawImage rawimage;
    // Use this for initialization
    void Start () {
        webcamTexture = new WebCamTexture();
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = webcamTexture;
        rawimage.texture = webcamTexture;
        rawimage.material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(webcamTexture.GetPixels());
    }
}
