using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    interface IPlayable
    {
        void Play();
    }
    class VideoPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing video...");
            Console.WriteLine();
        }
    }
    class MusicPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing music...");
        }
    }
    class MultipleInheritanceUsingInterface
    {
        static void Main()
        {
            VideoPlayer VP = new VideoPlayer();
            VP.Play();
            MusicPlayer MP = new MusicPlayer();
            MP.Play();
        }
    }
}
