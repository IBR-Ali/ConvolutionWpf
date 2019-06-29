﻿namespace CardioClinic
{
    public interface IHeart
    {
        void Connect();

        string GetStatus();
      
        double HeartRate { get; set; }
    }
}