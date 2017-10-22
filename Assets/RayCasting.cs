using UnityEngine;
using System.Collections;
using System;

public class RayCasting : MonoBehaviour {
    float lenthRay = 200f;
    Vector3 originePos;
    Vector3 dir;
    RaycastHit hitinfo;
    GameObject hitten;
    LineRenderer ray;
    bool isHitting;
    Color beforC;

    void Start()
    {
        ray = GameObject.FindGameObjectWithTag("Ray").GetComponent<LineRenderer>();
    }

    IEnumerator HideBall(GameObject ball)
    {
        ball.SetActive(false);
        yield return new WaitForSeconds(5);
        ball.SetActive(true);
    }

    void Update()
    {
        //ray.
        if (Input.GetButton("Fire1")) {
            originePos = transform.position;
            ray.enabled = true;
            Quaternion rot = transform.rotation;
            dir = transform.right;
            Debug.DrawRay(originePos, dir, Color.blue);
            ray.SetPosition(0, transform.position + transform.right * 3);
            ray.SetPosition(1, transform.position + transform.right * 200);
            if (Physics.Raycast(originePos, dir, out hitinfo, lenthRay))
            {

                hitten = hitinfo.transform.gameObject;
                if (hitinfo.collider.tag == "Ball")
                    StartCoroutine(HideBall(hitinfo.collider.gameObject));
            }
            //hitten.transform.GetComponent<MeshRenderer> ().material.color = beforC;
            if (hitten != null)
            {
                print(hitten.name);
            }
        }
        if (Input.GetButtonUp("Fire1"))
        {
            ray.enabled = false;
        }
    }
}
