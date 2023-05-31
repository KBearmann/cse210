public class Cycling : Activity
{
    int _speed;
    public Cycling(int speed, string date, int length) : base (date, length)
    {
        _speed = speed;
    }
    public override double Distance()
    {
        return _length * Speed();
    }
    public override double Speed()
    {
        return this._speed;
    }
    public override double Pace()
    {
        return 60 / Speed();
    }
    public override void Summary()
    {
        _activity = "Cycling";
        base.Summary();
    }
}
