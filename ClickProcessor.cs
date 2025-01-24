using UnityEngine;
using UnityEngine.Events;

public class ClickProcessor : MonoBehaviour
{
    public event UnityAction OnClicked;

    private void OnMouseDown()
    {
        OnClicked?.Invoke();
    }
}
