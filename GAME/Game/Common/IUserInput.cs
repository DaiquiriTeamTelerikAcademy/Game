namespace Game.Common
{
    using System;

    public interface IUserInput
    {
        event EventHandler OnLeftPressed;

        event EventHandler OnRightPressed;

        event EventHandler OnActionPressed;

        void ProcessInput();//proverqva dali i natisnato nalqvo ili nadqsno i ako e producira sabitieto OnRightPressed ....
    }
}
