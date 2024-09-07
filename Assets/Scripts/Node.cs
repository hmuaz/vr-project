using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public bool isHandTouching = false;

    public bool gripActivated = false;

    public Transform rightHand;

    void Start()
    {
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, transform.position);

        rightHand = GameObject.FindGameObjectWithTag("RightHand").GetComponent<Transform>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RightHand"))
        {
            Debug.Log("Player tetikleyici alana girdi!");
            isHandTouching = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("RightHand"))
        {
            Debug.Log("Player tetikleyici alanından çıktı!");
            isHandTouching = false;

        }
    }



    public void ClickedGripWhileHandInNode()
    {
        if (isHandTouching)
        {
            gripActivated = true;

        }
    }

    public void UnClickedGripWhileHandInNode()
    {
        if (isHandTouching)
        {
            gripActivated = false;

            Debug.Log("menü aç");
        }
    }

    void Update()
    {
        if (gripActivated)
        {
            lineRenderer.SetPosition(1, rightHand.position);
        }
    }

    




}
