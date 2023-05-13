using System;
using UnityEngine;
using UnityEngine.UI;

//View class for UI
public sealed class HeartView : MonoBehaviour
{
    //Поля для кнопок дій
    [SerializeField] private Button _moveButton;
    [SerializeField] private Button _rotateButton;
    [SerializeField] private Button _scaleButton;
    
    public event Action OnMoveButtonClicked;
    public event Action OnRotateButtonClicked;
    public event Action OnScaleButtonClicked;
    
    //Підписуємо кнопки на Event
    private void Awake()
    {
        _moveButton.onClick.AddListener(() => OnMoveButtonClicked?.Invoke());
        _rotateButton.onClick.AddListener(() => OnRotateButtonClicked?.Invoke());
        _scaleButton.onClick.AddListener(() => OnScaleButtonClicked?.Invoke());
    }
    
    //Відписуємо кнопки на Event
    private void OnDestroy()
    {
        _moveButton.onClick.RemoveAllListeners();
        _rotateButton.onClick.RemoveAllListeners();
        _scaleButton.onClick.RemoveAllListeners();
    }
}