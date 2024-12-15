using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float _timeToWait = 2.4f;
    MeshRenderer _meshRenderer;
    Rigidbody _rigidBody;
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _rigidBody.useGravity = false;

        _meshRenderer = GetComponent<MeshRenderer>();
        _meshRenderer.enabled = false;
    }

    void Update()
    {
        if (Time.time > _timeToWait)
        {
            _rigidBody.useGravity = true;
            _meshRenderer.enabled = true;
        }
    }
}
