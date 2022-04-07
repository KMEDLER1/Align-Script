using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlignRender2 : MonoBehaviour
{
    public GameObject ForwardRef;

    // Start is called before the first frame update
    private void Start()
    {
        if (ForwardRef == null && transform.parent != null)
        {
            ForwardRef = transform.parent.gameObject;
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (ForwardRef == null) { return; }
        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.up, out hit))
        {
            Vector3 forward = ForwardRef.transform.up;
            Debug.DrawRay(transform.position, forward * 3, Color.green);

            Vector3 up = hit.normal;

            Debug.DrawRay(transform.position, up * 3, Color.blue);
            Vector3 project = Vector3.ProjectOnPlane(forward, up);
            Debug.DrawRay(transform.position, project * 3, Color.red);

            Quaternion rotation = Quaternion.LookRotation(project, up);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 10 * Time.deltaTime);
        }
    }
}