using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{

    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _direction;
    private Camera mainCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        mainCamera.enabled = true;
        Debug.Log("transform.position: ");
        Debug.Log(transform.position);
        mainCamera.transform.position = transform.position;
        Debug.Log("mainCamera.transform.position: ");
        Debug.Log(mainCamera.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        //  moving by arrows
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");
        
        
    }

    private void FixedUpdate()
    {
        //  correct speed and move Person
        var speed = _direction * _speed * Time.deltaTime;
        transform.Translate((speed));

        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        mainCamera.transform.Translate(speed);
    }
}
