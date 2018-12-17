﻿namespace BallsIoServer
{
    public class Circle
    {
        public Point Position { get; set; }

        public int Score { get; set; }

        public Circle(Point position = null, int score = 1)
        {
            Position = position ?? new Point();
            Score = score;
        }
    }
}
