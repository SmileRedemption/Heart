using UnityEngine;

public sealed class GameInitializer : MonoBehaviour
{
    [SerializeField] private HeartView _heartView;
    [SerializeField] private Config _config;
    
    private HeartPresenter _heartPresenter;
    
    private void Awake() =>
        _heartPresenter = new HeartPresenter(new Heart(_heartView.transform,_config), _heartView);

    private void OnEnable() => 
        _heartPresenter.Enable();

    private void OnDisable() => 
        _heartPresenter.Disable();
}