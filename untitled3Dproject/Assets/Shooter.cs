using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    LineRenderer lineRenderer;
    WaitForSeconds shotDuration = new WaitForSeconds(0.07f);

    // Start is called before the first frame update
    void Start()
    {
       //lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            lineRenderer.SetPosition(0, transform.position); 
            lineRenderer.SetPosition(1, transform.position + transform.forward * 100);
            StartCoroutine(Show()); 
        }
    }

    private IEnumerator Show() {
        lineRenderer.enabled = true;
        yield return shotDuration;
        lineRenderer.enabled = false;
    }
}
