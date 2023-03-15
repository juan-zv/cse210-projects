using System;

class Program
{
    static void Main(string[] args)
    {


        Breathing breathing = new Breathing();

        int _time = int.Parse(Console.ReadLine());

        breathing.SetDuration(_time);

        int duration = breathing.GetDuration();

        int _check = breathing.BreatheInOut();

        if (duration >= 0){
            breathing.BreatheInOut();
            duration = duration - _check;
        }
    }
}