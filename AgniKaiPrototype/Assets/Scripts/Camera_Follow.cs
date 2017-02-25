using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{

    public Transform target_player;
    public float m_speed = 0.1f;
    private Camera camera;
	// Use this for initialization
	void Start ()
	{
	    camera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    camera.orthographicSize = (Screen.height / 100f);

	    if (target_player)
	    {
	        transform.position = Vector3.Lerp(transform.position, target_player.position, m_speed) + new Vector3(0,0, -10);
	    }
	}
}
