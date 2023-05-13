using UnityEngine;

//Клас для ініціалізації скриптів що реалізують паттерн MVP
public sealed class GameInitializer : MonoBehaviour
{
    //Приватні поля з атрибутом SerializeField для можливості задання через інспектор
    [SerializeField] private HeartView _heartView; //View
    [SerializeField] private Config _config;//Data Class
    
    private HeartPresenter _heartPresenter;
    
    //Викликається при запуски гри, створюємо презентер, що пов'язує Model і View
    private void Awake() =>
        _heartPresenter = new HeartPresenter(new Heart(_heartView.transform,_config), _heartView);

    //Підписуємо на event View модель
    //Спрацьовує коли елемент вмикається
    private void OnEnable() => 
        _heartPresenter.Enable();
    
    //Відписуємось на event View модель
    //Спрацьовує коли елемент вимикається
    private void OnDisable() => 
        _heartPresenter.Disable();
}