using System;
using System.Speech.Synthesis;
namespace firstcsharpp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Hello Github");
            using (SpeechSynthesizer speek =
                new SpeechSynthesizer())
            {
                // speek.SelectVoice('Microsoft Zira');
                // synthesizer.SelectVoiceByHints(VoiceGender.Male , VoiceAge.Adult);
                speek.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                speek.Volume = 40;
                speek.Rate = 1;
                speek.Speak("hello github!");
                // speek.SpeakAsync("Hello Github!");
                Console.WriteLine("The current time is " + DateTime.Now);
                speek.Speak("The current time is " + DateTime.Now);
                Console.WriteLine("Enter your name : ");
                speek.Speak("Enter your name");
                name = Console.ReadLine();
                Console.WriteLine("Hello " + name);
                speek.Speak("Hello " + name);
            }

            // speechsynthesizer speek = new speechsynthesizer();



            //   //  Initialize a new instance of the SpeechSynthesizer.  
            //   SpeechSynthesizer synth = new SpeechSynthesizer();  

            //   // Configure the audio output.   
            //   synth.SetOutputToDefaultAudioDevice();  

            //   // Create a prompt from a string.  
            //   Prompt color = new Prompt("What is your favorite color?");  

            //   // Speak the contents of the prompt asynchronously.  
            //   synth.SpeakAsync(color);  

            //   Console.WriteLine();  
            //   Console.WriteLine("Press any key to exit...");  
            //   Console.ReadKey(); 


            //    // Speech helper
            //    SpeechSynthesizer reader = new SpeechSynthesizer();
            //    const string msg = "Hello";
            //    Console.WriteLine(msg);
            //    reader.SpeakAsync(msg);
        }

        // private class SpeechSynthesizer
        // {
        //     internal void SpeakAsync(string msg)
        //     {
        //         throw new NotImplementedException();
        //     }
        // }
    }
}
