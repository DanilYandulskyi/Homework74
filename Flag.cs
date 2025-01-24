using UnityEngine;
using UnityEngine.Events;

public class Flag : MonoBehaviour, IUnitTarget
{
    private BaseSpawner _baseSpawner;

    public event UnityAction<Flag> OnSpawn;

    public Transform Transform => transform;

    private void Start()
    {
        OnSpawn?.Invoke(this);
    }

    public Base SpawnBase()
    {
        return _baseSpawner.SpawnBase(transform.position);
    }

    public void SetPosition(Vector3 position)
    {
        gameObject.SetActive(true);
        Transform.position = position;
    }

    public void Disable()
    {
        gameObject.SetActive(false);
    }

    public Flag Spawn(Vector3 position)
    {
        return Instantiate(this, position, Quaternion.identity);
    }

    public Flag Initialize(BaseSpawner baseSpawner)
    {
        _baseSpawner = baseSpawner;

        return this;
    }
}
