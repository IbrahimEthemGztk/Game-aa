using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ForceQueternionIdentity : MonoBehaviour
{
    private void LateUpdate()
    {
        transform.rotation = quaternion.identity;
    }
}
