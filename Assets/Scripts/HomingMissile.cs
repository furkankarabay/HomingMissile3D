using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingMissile : MonoBehaviour
{
    private Rigidbody rgb;
    [SerializeField]
    private Transform target;

    public float speed = 10f;
    public float rotateSpeed = 100;

    private void Start()
    {
        rgb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        if (target != null)
        {
            Vector3 direction = target.position - rgb.position;

            direction.Normalize();

            Vector3 rotateAmount = Vector3.Cross(direction, transform.forward); //Roketin ilerisi ile arasındaki yönü çarp.

            rgb.angularVelocity = -rotateAmount * rotateSpeed; //Bulduğumuz açıyı açısal hıza ekle
            rgb.velocity = transform.forward * speed; //Sürekli roketin ileri gitsin.

        }
    }
}
