using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class NodeMaker : MonoBehaviour
{
    public Transform rightHand;
    public GameObject nodePrefab;
    public void InstantiateNode()
    {
        Instantiate(nodePrefab, rightHand.position, rightHand.rotation);
    }
}
