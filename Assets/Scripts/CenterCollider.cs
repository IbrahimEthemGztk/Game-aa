using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("BulletCenter"))
        {
            var bulletCenter = other.GetComponent<BulletCenterCollider>();
            bulletCenter.MyBullet.OnCompleted(transform.parent);
        }
        
    }
}
