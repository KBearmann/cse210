using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureManagement _list = new ScriptureManagement();
        Reference reference = new Reference(_list.GetSelecterReference());
        Scripture scripture = new Scripture(reference, _list.GetSelecterScripture());

    }

}
