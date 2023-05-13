using System;
using UnityEngine;

[Serializable]
public class Config
{
    [Header("Animation Data")]
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _scaleSize;
    
    [Header("Screen Data")]
    [SerializeField] private int _minX;
    [SerializeField] private int _maxX;
    [SerializeField] private int _minY;
    [SerializeField] private int _maxY;

    public float MoveSpeed => _moveSpeed;
    public float RotateSpeed => _rotateSpeed;
    public float ScaleSize => _scaleSize;

    public int MinX => _minX;
    public int MaxX => _maxX;
    public int MinY => _minY;
    public int MaxY => _maxY;
}