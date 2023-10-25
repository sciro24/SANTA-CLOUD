using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlloer : MonoBehaviour
{
    [SerializeField] private Transform Personaggio;

   private void Update()
    {
        transform.position = new Vector3(Personaggio.position.x, Personaggio.position.y, transform.position.z);
    }
}
