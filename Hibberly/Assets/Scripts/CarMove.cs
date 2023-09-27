using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    Transform transform;
    public float yspeed;
    public float xspeed;

    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float yAxis = Input.GetAxis("Vertical");
        float xAxis = Input.GetAxis("Horizontal");
        

        transform.Translate(Vector3.forward * Time.deltaTime * yspeed * yAxis);
        transform.Translate(Vector3.right * Time.deltaTime * xspeed * xAxis);

        cam.transform.position = transform.position + new Vector3(0.0f, 5.0f, -15.0f);
        void OnCollisionEnter (Collider obstacle)
        {

        }
    }
}
    