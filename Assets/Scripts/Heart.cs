using DG.Tweening;
using UnityEngine;

//Model що відповідає за дії з об'єктом
public sealed class Heart
{
    private readonly Transform _transform;//Компонент для роботи з положенням, поворотом і розміром об'єкта
    private readonly Config _config;//Data Class
    
    //Constructor
    public Heart(Transform transform, Config config)
    {
        _transform = transform;
        _config = config;
    }
    
    //За допомогою DOTween рухаємо анімовано об'єкт на позицію яку ми обрахували
    public void OnMove()
    {
        var newPosition = new Vector2(Random.Range(_config.MinX, _config.MaxX), Random.Range(_config.MinY, _config.MaxY));
        _transform.DOMove(newPosition, _config.MoveDuration);
    }

    //За допомогою DOTween повертаємо анімовано об'єкт на кут який ми обрахували
    public void OnRotate()
    {
        var newRotate = new Vector3(0,0,Random.Range(0, 180));
        _transform.DORotate(newRotate, _config.RotateDuration);
    }
    
    //За допомогою DOTween повертаємо масштабуємо об'єк

    public void OnScale()
    {
        var scale = Random.Range(0.5f, 2.0f);
        var newScale = new Vector2(scale,scale);
        _transform.DOScale(newScale, _config.ScaleDuration);
    }
}
