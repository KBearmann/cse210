public class Swimming : Activity
{
    int _laps;
    public Swimming(int laps, string date, int length) : base (date, length)
    {
        _laps = laps;
    }
    public override double Distance()
    {
        return this._laps * 50.0 / 1000;
    }
    public override double Speed()
    {
        return _length / this._laps;
    }
    public override double Pace()
    {
        return 60 / Speed();
    }
    public override void Summary()
    {
        _activity = "Swimming";
        base.Summary();
    }
}
