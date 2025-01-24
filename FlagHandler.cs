using UnityEngine;

public class FlagHandler : MonoBehaviour
{
    [SerializeField] private Flag _flagPrefab;
    [SerializeField] private Flag _spawnedFlag;
    [SerializeField] private BaseSpawner _baseSpawner;

    private bool _isFlagSet = false;

    public bool IsFlagSet => _isFlagSet;

    private void Update()
    {
        if (_spawnedFlag != null)
        {
            if (_spawnedFlag.isActiveAndEnabled == false)
            {
                _isFlagSet = false;
            }
        }
    }

    public void SetFlag(Vector3 position)
    {
        if (_isFlagSet)
        {
            _isFlagSet = true;
            _spawnedFlag.SetPosition(position);
        }
        else
        {
            _isFlagSet = true;
            _spawnedFlag = _flagPrefab.Spawn(position).Initialize(_baseSpawner);
            
        }
    }

    public Flag TryGetFlag()
    {
        return _spawnedFlag;
    }
}
