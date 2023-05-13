using DG.Tweening;
using UnityEngine;

public sealed class Heart
{
    private readonly Transform _transform;
    private readonly Config _config;
    
    public Heart(Transform transform, Config config)
    {
        _transform = transform;
        _config = config;
    }

    public void OnMove()
    {
        var newPosition = new Vector2(Random.Range(_config.MinX, _config.MaxX), Random.Range(_config.MinY, _config.MaxY));
        _transform.DOMove(newPosition, _config.MoveSpeed);
    }

    public void OnRotate()
    {
        var newRotate = new Vector3(0,0,Random.Range(0, 180));
        _transform.DORotate(newRotate, _config.RotateSpeed);
    }

    public void OnScale()
    {
        var scale = Random.Range(0.5f, 2.0f);
        var newScale = new Vector2(scale,scale);
        _transform.DOScale(newScale, _config.ScaleSize);
    }
}
