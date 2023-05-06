using System;

class Reference
{
    private string _reference = "";
    public Reference(){}
    public Reference(string reference)
    {
        _reference = reference;
    }

    public string GetReference(){return _reference;}


}
