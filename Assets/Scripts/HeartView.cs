using System;
using UnityEngine;
using UnityEngine.UI;

public sealed class HeartView : MonoBehaviour
{
    [SerializeField] private Button _moveButton;
    [SerializeField] private Button _rotateButton;
    [SerializeField] private Button _scaleButton;
    
    public event Action OnMoveButtonClicked;
    public event Action OnRotateButtonClicked;
    public event Action OnScaleButtonClicked;

    private void Awake()
    {
        _moveButton.onClick.AddListener(() => OnMoveButtonClicked?.Invoke());
        _rotateButton.onClick.AddListener(() => OnRotateButtonClicked?.Invoke());
        _scaleButton.onClick.AddListener(() => OnScaleButtonClicked?.Invoke());
    }

    private void OnDestroy()
    {
        _moveButton.onClick.RemoveAllListeners();
        _rotateButton.onClick.RemoveAllListeners();
        _scaleButton.onClick.RemoveAllListeners();
    }
}