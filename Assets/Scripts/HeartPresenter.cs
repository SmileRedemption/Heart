

public sealed class HeartPresenter
{
    private readonly Heart _model;
    private readonly HeartView _view;

    public HeartPresenter(Heart model, HeartView view)
    {
        _model = model;
        _view = view;
    }
    
    //Підписуємо на event View модель
    public void Enable()
    {
        _view.OnMoveButtonClicked += _model.OnMove;
        _view.OnRotateButtonClicked += _model.OnRotate;
        _view.OnScaleButtonClicked += _model.OnScale;
    }
    
    //Відписуємось на event View модель
    public void Disable()
    {
        _view.OnMoveButtonClicked -= _model.OnMove;
        _view.OnRotateButtonClicked -= _model.OnRotate;
        _view.OnScaleButtonClicked -= _model.OnScale;
    }
}