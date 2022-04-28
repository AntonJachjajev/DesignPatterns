﻿namespace DesignPatterns.Adaptor
{
    public interface IAdvancedMediaPlayer
    {
        public void PlayVlc(string fileName);
        public void PlayMp4(string fileName);
    }
}