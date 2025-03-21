using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 defaultDistance = new Vector3(0, 0, -10);
    [SerializeField] float smoothing = 2f;
    Transform t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 CamPos = target.position + defaultDistance;
        t.position = Vector3.Lerp(t.position, CamPos, smoothing * Time.deltaTime);
    }

    void Awake()
    {
        t = transform;
    }
}
