namespace Assets.Scripts.Player
{
    public class Joystick
    {
        public readonly string Horizontal;
        public readonly string Vertical;

        public Joystick(int playerNumber)
        {
            Horizontal = "Horizontal_P" + playerNumber;
            Vertical = "Vertical_P" + playerNumber;
        }

    }
}
