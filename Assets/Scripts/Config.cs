using System;
using UnityEngine;

//Атрибут для можливості встановлення данних у редакторі Unity
[Serializable]
public class Config
{
    //Приватні поля з атрибутом SerializeField для можливості задання через інспектор
    //Animation Data дані для передання у модель
    [Header("Animation Data")]
    [SerializeField] private float _moveDuration;
    [SerializeField] private float _rotateDuration;
    [SerializeField] private float _scaleDuration;
    
    //Screen Data дані де може рухатися елемент
    [Header("Screen Data")]
    [SerializeField] private int _minX;
    [SerializeField] private int _maxX;
    [SerializeField] private int _minY;
    [SerializeField] private int _maxY;

    public float MoveDuration => _moveDuration;
    public float RotateDuration => _rotateDuration;
    public float ScaleDuration => _scaleDuration;

    public int MinX => _minX;
    public int MaxX => _maxX;
    public int MinY => _minY;
    public int MaxY => _maxY;
}