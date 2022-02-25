using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBoarder : MonoBehaviour
{    
    // OnCollision Event  �� 
    // Rigidbody �� Collider �Ǵ�
    // Collider �� RigidBody �� �浹�� �� ȣ��Ǵ� �̺�Ʋ�Լ�.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == null) return;

        Destroy(collision.gameObject);
    }
}
