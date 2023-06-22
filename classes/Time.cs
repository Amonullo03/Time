namespace classes;
public class Time
{
    private int _hour;
    private int _minute;
    private int _second;

    public Time()
    {

    }
    public Time(int hour, int minute, int second)
    {
        _hour = hour;
        _minute = minute;
        _second = second;
    }

    public int GetHour()
    {
        return _hour;
    }

    public int GetMinute()
    {
        return _minute;
    }

    public int GetSecond()
    {
        return _second;
    }

    public void SetHour(int hour)
    {
        _hour = hour;
    }

    public void SetMinute(int minute)
    {
        _minute = minute;
    }

    public void SetSecond(int second)
    {
        _second = second;
    }

    public string ToString()
    {

        if (_minute >= 0 && _minute <= 9 && _second >= 0 && _second <= 9)
        {
            return $"{_hour}:0{_minute}:0{_second}";
        }
        else if (_minute >= 0 && _minute <= 9)
        {
            return $"{_hour}:0{_minute}:{_second}";
        }
        else if (_second >= 0 && _second <= 9)
        {
            return $"{_hour}:{_minute}:0{_second}";
        }
        else
        {
            return $"{_hour}:{_minute}:{_second}";
        }
    }

    public void SetTime(int hour, int minute, int second)
    {
        _hour = hour;
        _minute = minute;
        _second = second;
    }

    public Time nextSecond()
    {
        ++_second;
        if (_second >= 60)
        {
            _second = 0;
            ++_minute;
            if (_minute >= 60)
            {
                _minute = 0;
                ++_hour;
                if (_hour >= 24)
                {
                    _hour = 0;
                }
            }
        }
        return this;
    }
}