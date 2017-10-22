using UnityEngine;
using System.Collections;

public class CollisionDestroy : MonoBehaviour {
    public Transform explosionPrefab;
    void OnCollisionEnter(Collision col)
    {
        var contact = col.contacts[2];
        var rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        var pos = contact.point;
        Instantiate(explosionPrefab, pos, rot);
        Destroy(gameObject, 0);
    }
}
